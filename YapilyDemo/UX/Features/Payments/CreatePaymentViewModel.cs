using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reactive;
using System.Reactive.Concurrency;
using System.Threading.Tasks;
using Appmilla.Xamarin.Infrastructure.Framework;
using Appmilla.Xamarin.Infrastructure.Reactive;
using Appmilla.Yapily.Refit.Caches;
using Appmilla.Yapily.Refit.Models;
using Appmilla.Yapily.Refit.Queries;
using Appmilla.Yapily.Refit.Storage;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Xamarin.Essentials;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;
using YapilyDemo.Framework;
using YapilyDemo.UX.Features.Shared;

namespace YapilyDemo.UX.Features.Payments
{
    public class CreatePaymentViewModel : ReactiveObject, IViewModel, INavigationAware
    {
        readonly ISchedulerProvider _schedulerProvider;
        readonly ISinglePaymentQuery _singlePaymentQuery;
        readonly ISecureStorage _secureStorage;
        readonly IConnectedInstitutionsCache _connectedInstitutionsCache;
        
        public string Id => NavigationPageKeys.ChooseBankPageKey;
        
        [Reactive]
        public string Title { get; private set; } = "Yapily Demo would like to setup a payment from your account. Check the details, then continue or cancel.";

        [Reactive] public string Amount { get; set; }
        
        [Reactive] public string Currency { get; set; } = "GBP";
        
        [Reactive] public string Recipient { get; set; } = "Barclays Sandbox LTD";

        [Reactive] public string SortCode { get; set; } = "202045";

        [Reactive] public string AccountNumber { get; set; } = "13243522";

        [Reactive] public string Reference { get; set; } = "Coffee";
        
        [Reactive]
        public AccountViewModel PayerAccount { get; set; }
        
        [Reactive]
        public string Status { get; private set; }
        
        [Reactive]
        public bool ShowStatus { get; private set; }
        
        public ReactiveCommand<Unit, Unit> Continue { get; }
        
        public ReactiveCommand<Unit, Unit> Cancel { get; }
        
        public CreatePaymentViewModel(
            ISchedulerProvider schedulerProvider,
            ISinglePaymentQuery singlePaymentQuery,
            ISecureStorage secureStorage,
            IConnectedInstitutionsCache connectedInstitutionsCache)
        {
            _schedulerProvider = schedulerProvider;
            _singlePaymentQuery = singlePaymentQuery;
            _secureStorage = secureStorage;
            _connectedInstitutionsCache = connectedInstitutionsCache;
            
            Continue = ReactiveCommand.CreateFromTask(OnContinue, outputScheduler: _schedulerProvider.MainThread);
            Continue.ThrownExceptions.Subscribe(Continue_OnError);
            
            Cancel = ReactiveCommand.CreateFromTask(OnCancel, outputScheduler: _schedulerProvider.MainThread);
            Cancel.ThrownExceptions.Subscribe(Cancel_OnError);
        }
        
        public Task OnViewAppearing()
        {
            return Task.CompletedTask;
        }

        public Task OnViewDisappearing()
        {
            Status = String.Empty;

            ShowStatus = false;
            
            return Task.CompletedTask;
        }
        
        async Task OnCancel()
        {
            await Shell.Current.GoToAsync("..");
        }
        
        void Cancel_OnError(Exception exception)
        {
            Debug.WriteLine($"Error {exception.Message}");
        }
        
        async Task OnContinue()
        {
            try
            {
                var applicationUserId = await _secureStorage.GetAsync(StorageKeys.ApplicationUserId);
                var userUuid = await _secureStorage.GetAsync(StorageKeys.UserUuid);

                var paymentRequest = new PaymentRequest
                {
                    Amount = new Amount
                    {
                        Amount1 = Math.Round(Convert.ToDouble(Amount), 2),
                        Currency = Currency
                    },
                    PaymentIdempotencyId = Guid.NewGuid().ToString("N"),
                    Payer = new Payer
                    {
                        AccountIdentifications = PayerAccount.AccountIdentifications,
                        /*Address = new Address
                        {
                            Country = "UK"
                        },*/
                        Name = PayerAccount.Name

                    },
                    ContextType = PaymentRequestContextType.BILL,
                    Payee = new Payee
                    {
                        AccountIdentifications = new List<AccountIdentification>()
                        {
                            new AccountIdentification
                            {
                                Type = AccountIdentificationType.SORT_CODE,
                                Identification = SortCode
                            },
                            new AccountIdentification
                            {
                                Type = AccountIdentificationType.ACCOUNT_NUMBER,
                                Identification = AccountNumber
                            }
                        },
                        Name = Recipient,
                        /*Address = new Address()
                        {
                            Country = "UK"
                        }*/
                    },
                    PaymentDateTime = DateTimeOffset.UtcNow.AddMinutes(2),
                    Reference = Reference,
                    Type = PaymentRequestType.DOMESTIC_PAYMENT
                };
                
                var paymentAuthRequest = new PaymentAuthorisationRequest
                {
                    UserUuid = userUuid,
                    ApplicationUserId = applicationUserId,
                    InstitutionId = PayerAccount.InstitutionId,
                    Callback = "com.intuitive.yapilydemo://callback",
                    PaymentRequest = paymentRequest
                };

                var paymentAuthorisationResponse =
                    await _singlePaymentQuery.CreatePaymentAuthorisationRequest(paymentAuthRequest);
                
                Debug.WriteLine(paymentAuthorisationResponse);
                
                var authResult = await WebAuthenticator.AuthenticateAsync(new Uri(paymentAuthorisationResponse.Data.AuthorisationUrl), new Uri(paymentAuthRequest.Callback));
                
                Debug.WriteLine(authResult);

                if (authResult.Properties.ContainsKey("consent"))
                {
                    string consentToken;
                    if (authResult.Properties.TryGetValue("consent", out consentToken))
                    {
                        var paymentResponse =
                            await _singlePaymentQuery.CreatePaymentRequest(consentToken, paymentRequest);
                        
                        _schedulerProvider.MainThread.Schedule(() =>
                        {
                            Status = paymentResponse.Data.Status.ToString();

                            ShowStatus = true;
                        });
                    }
                }
            }
            catch (Exception exception)
            {
                Debug.WriteLine($"Error {exception.Message}");
                throw;
            }
        }
        
        void Continue_OnError(Exception exception)
        {
            Debug.WriteLine($"Error {exception.Message}");
        }
        
        
        
        
    }
}