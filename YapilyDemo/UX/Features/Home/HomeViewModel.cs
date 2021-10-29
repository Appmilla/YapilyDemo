using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Reactive;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Threading.Tasks;
using Appmilla.Xamarin.Infrastructure.Extensions;
using Appmilla.Xamarin.Infrastructure.Framework;
using Appmilla.Xamarin.Infrastructure.Reactive;
using Appmilla.Yapily.Refit.Caches;
using Appmilla.Yapily.Refit.Database;
using Appmilla.Yapily.Refit.Queries;
using DynamicData;
using DynamicData.Binding;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace YapilyDemo.UX.Features.Home
{
    public class HomeViewModel : ReactiveObject, INavigationAware
    {
        readonly ISchedulerProvider _schedulerProvider;
        readonly IConnectedInstitutionsCache _connectedInstitutionsCache;
        readonly IAccountsQuery _accountsQuery;
        readonly ISecureStorage _secureStorage;
        readonly ITransactionsQuery _transactionsQuery;
        
        bool _hasLoaded;
        
        ReadOnlyObservableCollection<ConnectedInstitution> _connectedInstitutions;
        ReadOnlyObservableCollection<InstitutionSummaryViewModel> _institutionSummaries;
        
        public ReadOnlyObservableCollection<ConnectedInstitution> ConnectedInstitutions
        {
            get => _connectedInstitutions;
            set => this.RaiseAndSetIfChanged(ref _connectedInstitutions, value);
        }
        
        public ReadOnlyObservableCollection<InstitutionSummaryViewModel> InstitutionSummaries
        {
            get => _institutionSummaries;
            set => this.RaiseAndSetIfChanged(ref _institutionSummaries, value);
        }   
        
        private static readonly Func<InstitutionSummaryViewModel, string> KeySelector = summary => summary.InstitutionId;
        readonly SourceCache<InstitutionSummaryViewModel, string> _institutionSummariesCache = new SourceCache<InstitutionSummaryViewModel, string>(KeySelector);
        
        [ObservableAsProperty]
        // ReSharper disable once UnassignedGetOnlyAutoProperty
        public bool IsBusy { get; }
        
        public ReactiveCommand<Unit, Unit> Load { get; }
        
        public ReactiveCommand<Unit, Unit> Refresh { get; }
        
        public ReactiveCommand<Unit, Unit> ChooseBank { get; }
        
        [Reactive]
        public string Title { get; private set; } = "Your accounts";
        
        public HomeViewModel(
            ISchedulerProvider schedulerProvider,
            IConnectedInstitutionsCache connectedInstitutionsCache,
            IAccountsQuery accountsQuery,
            ISecureStorage secureStorage,
            ITransactionsQuery transactionsQuery)
        {
            _schedulerProvider = schedulerProvider;            
            _connectedInstitutionsCache = connectedInstitutionsCache;
            _accountsQuery = accountsQuery;  
            _secureStorage = secureStorage;
            _transactionsQuery = transactionsQuery;
            
            var institutionsSort = SortExpressionComparer<InstitutionSummaryViewModel>
                .Ascending(i => i.Name);

            _ = _institutionSummariesCache.Connect()
                .Sort(institutionsSort)
                .Bind(out _institutionSummaries)
                .ObserveOn(schedulerProvider.MainThread)        //ensure operation is on the UI thread;
                .DisposeMany()                              //automatic disposal
                .Subscribe();
            
            Load = ReactiveCommand.CreateFromTask(_ => OnLoad(false),
                    this.WhenAnyValue(x => x.IsBusy).Select(x => !x),
                    outputScheduler: _schedulerProvider.ThreadPool);
            Load.ThrownExceptions.Subscribe(OnError);
                
            Refresh = ReactiveCommand.CreateFromTask(_ => OnRefresh(),
                this.WhenAnyValue(x => x.IsBusy).Select(x => !x),
                outputScheduler: _schedulerProvider.ThreadPool);
            Refresh.ThrownExceptions.Subscribe(OnError);
            
            ChooseBank = ReactiveCommand.CreateFromTask(OnChooseBank, outputScheduler: _schedulerProvider.MainThread);
            ChooseBank.ThrownExceptions.Subscribe(ChooseBank_OnError);
            
            _ = _connectedInstitutionsCache.ConnectedInstitutions.Connect()
                .Bind(out _connectedInstitutions)
                .ObserveOn(_schedulerProvider.MainThread)        //ensure operation is on the UI thread;
                .DisposeMany()                              //automatic disposal
                .Subscribe();
            
            _connectedInstitutionsCache.ConnectedInstitutionsDataNotifications
                .ObserveOn(_schedulerProvider.MainThread)        //ensure operation is on the UI thread;
                .Subscribe(InstitutionsCache_OnData);
        }

        void InstitutionsCache_OnData(ConnectedInstitutionsDataAvailable dataAvailable)
        {
            Observable.Return(Unit.Default).InvokeCommand(Refresh);
        }
        
        private Task OnLoad(bool reset)
        {
            var results = _connectedInstitutions.Select(ci => new InstitutionSummaryViewModel(
                _schedulerProvider,
                _accountsQuery,
                _secureStorage,
                _transactionsQuery)
            {
                InstitutionId = ci.InstitutionId,
                Name = ci.Name,
                ImageUrl = ci.ImageUrl
            });

            var institutionSummaryViewModels = results.ToList();
            foreach (var institutionSummary in institutionSummaryViewModels)
            {
                Observable.Return(Unit.Default).InvokeCommand(institutionSummary.LoadAccounts);
            }
            
            _schedulerProvider.MainThread.Schedule(_ =>
            {
                if (reset)
                {
                    _institutionSummariesCache.Clear();
                }
                _institutionSummariesCache.UpdateCache(institutionSummaryViewModels, KeySelector);
            });
            
            return Task.CompletedTask;
        }

        private async Task OnRefresh()
        {
            await OnLoad(true);
        }
        
        public Task OnViewAppearing()
        {
            if (!_hasLoaded)
            {
                _hasLoaded = true;

                Observable.Return(Unit.Default).InvokeCommand(Load);
            }

            return Task.CompletedTask;
        }

        public Task OnViewDisappearing()
        {
            return Task.CompletedTask;
        }
        
        void OnError(Exception exception)
        {
            Debug.WriteLine($"Error {exception.Message}");
        }
        
        async Task OnChooseBank()
        {
            await Shell.Current.GoToAsync("chooseBank");   
        }

        void ChooseBank_OnError(Exception exception)
        {
            Debug.WriteLine($"Error {exception.Message}");
        }
    }
}
