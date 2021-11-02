using System;
using System.Collections.Generic;
using System.Reactive;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Threading;
using System.Threading.Tasks;
using Appmilla.Xamarin.Infrastructure.Identity;
using Appmilla.Xamarin.Infrastructure.Reactive;
using Appmilla.Xamarin.Infrastructure.Utilities;
using Appmilla.Yapily.Refit.Caches;
using Appmilla.Yapily.Refit.Database;
using Autofac;
using CommonServiceLocator;
using ReactiveUI;
using SQLite;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YapilyDemo.UX;
using YapilyDemo.UX.Features.ApplicationShell;

namespace YapilyDemo
{
    public partial class App : Application
    {
        //IConnectedInstitutionsDb _connectedInstitutionsDb;
        public static IContainer Container { get; set; }
        
        public App()
        {
            InitializeComponent();
            
            MainPage = new AppShell();
            
            //var connectedInstitutions = AsyncHelper.RunSync(InitialiseDatabase);

            var secureStorage = ServiceLocator.Current.GetInstance<ISecureStorage>();
            var idToken = AsyncHelper.RunSync(() => secureStorage.GetAsync(IdentityKeys.IdToken));
            
            //idToken = String.Empty; //TODO delete
            if (string.IsNullOrEmpty(idToken))
            {
                Shell.Current.GoToAsync("//welcome"); 
            }
            else
            {
                var connectedInstitutionsCache = ServiceLocator.Current.GetInstance<IConnectedInstitutionsCache>();
                Observable.Return(Unit.Default).InvokeCommand(connectedInstitutionsCache.Load);
                
                Shell.Current.GoToAsync("//main");
                
                /*
                if (connectedInstitutions.Count > 0)
                {
                    Shell.Current.GoToAsync("//main");
                }
                else
                {
                    Shell.Current.GoToAsync("//chooseBank");                
                }  
                */ 
            }
            
            //Shell.Current.GoToAsync("//chooseBank"); 
            
            //MainPage = new MainView();
        }

        /*
        public Task<List<ConnectedInstitution>> InitialiseDatabase()
        {
            _connectedInstitutionsDb = ServiceLocator.Current.GetInstance<IConnectedInstitutionsDb>();
            
            if (_connectedInstitutionsDb.IsInitialised) return (Task<List<ConnectedInstitution>>)Task.CompletedTask;
            var tcs = new TaskCompletionSource<List<ConnectedInstitution>>(TaskCreationOptions.RunContinuationsAsynchronously);

            var schedulerProvider = ServiceLocator.Current.GetInstance<ISchedulerProvider>();
            var connectedInstitutionsCache = ServiceLocator.Current.GetInstance<IConnectedInstitutionsCache>();
            //_ = Observable.StartAsync(async () =>
            //{
                schedulerProvider.ThreadPool.Schedule(async () =>
                {
                    var connectedInstitutions = new List<ConnectedInstitution>();
                    
                    try
                    {
                        var createTable = await _connectedInstitutionsDb.CreateTable();
                        if (createTable == CreateTableResult.Created || createTable == CreateTableResult.Migrated)
                        {
                            connectedInstitutions = await connectedInstitutionsCache.Load.Execute().FirstAsync();
                            //connectedInstitutions = _connectedInstitutionsDb.GetInstitutionsAsync().Result;
                        }
                    }
                    finally
                    {
                        tcs.SetResult(connectedInstitutions);
                    }
                });
            //}, schedulerProvider.ThreadPool);

            return tcs.Task;
        }
        */
        
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
