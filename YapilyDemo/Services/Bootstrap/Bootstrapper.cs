using System.Reactive.Concurrency;
using Akavache;
using Appmilla.Xamarin.Infrastructure.Reactive;
using Appmilla.Yapily.Refit.Caches;
using Appmilla.Yapily.Refit.Configuration;
using Appmilla.Yapily.Refit.Database;
using Appmilla.Yapily.Refit.Http;
using Appmilla.Yapily.Refit.Queries;
using ReactiveUI;
using Splat.Autofac;
using Autofac;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Refit;
using Xamarin.Essentials.Interfaces;
using Xamarin.Essentials.Implementation;
using YapilyDemo.UX;
using YapilyDemo.UX.Features.AccountDetails;
using YapilyDemo.UX.Features.ApplicationShell;
using YapilyDemo.UX.Features.AuthenticateLogin;
using YapilyDemo.UX.Features.ConnectBank;
using YapilyDemo.UX.Features.Home;
using YapilyDemo.UX.Features.More;
using YapilyDemo.UX.Features.Payments;
using YapilyDemo.UX.Features.Shared;

namespace YapilyDemo.Services.Bootstrap
{
    public static class Bootstrapper
    {
        public static void Bootstrap(ContainerBuilder containerBuilder)
        {            
            SetupXamarinEssentials(containerBuilder);

            SetupServices(containerBuilder);

            SetupViewModels(containerBuilder);
        }
        
        public static void PostContainerBuild()
        {
        } 
        
        static void SetupXamarinEssentials(ContainerBuilder builder)
        {
            // register the IMainThread but prefer to use the ISchedulerProvider.Dispatcher.Schedule
            builder.RegisterType<MainThreadImplementation>().As<IMainThread>().SingleInstance();
            builder.RegisterType<SecureStorageImplementation>().As<ISecureStorage>().SingleInstance();
            builder.RegisterType<PreferencesImplementation>().As<IPreferences>().SingleInstance();
        }

        static void SetupServices(ContainerBuilder builder)
        {
            // Akavache asks the container for this, if not found uses the TaskPoolScheduler.Default
            // so by adding it to the container we reduce the number of first chance exceptions thrown
            // this registration can be removed and the app still works ok
            var taskPoolScheduler = TaskPoolScheduler.Default;
            builder.RegisterInstance<IScheduler>(taskPoolScheduler).Named<IScheduler>("Taskpool");
            
            builder.RegisterType<SchedulerProvider>().As<ISchedulerProvider>().SingleInstance();
            
            JsonConvert.DefaultSettings =
                () => new JsonSerializerSettings() {
                    ContractResolver = new CamelCasePropertyNamesContractResolver(),
                    DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                    NullValueHandling = NullValueHandling.Ignore,
                    Converters = {new StringEnumConverter()}
                };
            
            var refitSettings = new RefitSettings(new NewtonsoftJsonContentSerializer());
            
            builder.RegisterInstance(refitSettings).As<RefitSettings>().SingleInstance();

            var yapilyConfiguration = new YapilyConfiguration();
            yapilyConfiguration.Username = "7b67086c-2f2d-4b03-9c4d-96d57bc294ac";
            yapilyConfiguration.Password = "4c40bc5d-fb96-4d1e-9b33-be9684c1c20c";
            builder.RegisterInstance<IYapilyConfiguration>(yapilyConfiguration);
            
            builder.RegisterType<YapilyHttpClientFactory>().As<IYapilyHttpClientFactory>().SingleInstance();

            builder.RegisterType<ConnectedInstitutionsDb>().As<IConnectedInstitutionsDb>().SingleInstance();
            builder.RegisterType<ConnectedInstitutionsCache>().As<IConnectedInstitutionsCache>().SingleInstance();
            
            builder.Register(c =>
                {
                    var blobCache = c.ResolveKeyed<IBlobCache>(AkavacheConstants.LocalMachine);
                    var yapilyHttpClientFactory = c.Resolve<IYapilyHttpClientFactory>();
                    var refitSettings = c.Resolve<RefitSettings>();
                    
                    return new ApplicationQuery(
                        blobCache,
                        yapilyHttpClientFactory,
                        refitSettings);
                }).As<IApplicationQuery>()
                .SingleInstance();
            
            builder.Register(c =>
                {
                    var blobCache = c.ResolveKeyed<IBlobCache>(AkavacheConstants.LocalMachine);
                    var yapilyHttpClientFactory = c.Resolve<IYapilyHttpClientFactory>();
                    var schedulerProvider = c.Resolve<ISchedulerProvider>();
                    var refitSettings = c.Resolve<RefitSettings>();

                    return new InstituitionsQuery(
                        blobCache,
                        yapilyHttpClientFactory,
                        schedulerProvider,
                        refitSettings);
                }).As<IInstituitionsQuery>()
                .SingleInstance();
            
            builder.Register(c =>
                {
                    var blobCache = c.ResolveKeyed<IBlobCache>(AkavacheConstants.LocalMachine);
                    var yapilyHttpClientFactory = c.Resolve<IYapilyHttpClientFactory>();
                    var schedulerProvider = c.Resolve<ISchedulerProvider>();
                    var refitSettings = c.Resolve<RefitSettings>();

                    return new AccountsQuery(
                        blobCache,
                        yapilyHttpClientFactory,
                        schedulerProvider,
                        refitSettings);
                }).As<IAccountsQuery>()
                .SingleInstance();
            
            builder.Register(c =>
                {
                    var blobCache = c.ResolveKeyed<IBlobCache>(AkavacheConstants.LocalMachine);
                    var yapilyHttpClientFactory = c.Resolve<IYapilyHttpClientFactory>();
                    var schedulerProvider = c.Resolve<ISchedulerProvider>();
                    var refitSettings = c.Resolve<RefitSettings>();

                    return new TransactionsQuery(
                        blobCache,
                        yapilyHttpClientFactory,
                        schedulerProvider,
                        refitSettings);
                }).As<ITransactionsQuery>()
                .SingleInstance();
            
            
        }

        static void SetupViewModels(ContainerBuilder builder)
        {
            builder.RegisterType<AppShellViewModel>().AsSelf().SingleInstance();
            builder.RegisterType<WelcomeViewModel>().AsSelf().SingleInstance();
            builder.RegisterType<ChooseBankViewModel>().AsSelf().SingleInstance();
            builder.RegisterType<HomeViewModel>().AsSelf().SingleInstance();
            builder.RegisterType<MainViewModel>().AsSelf().SingleInstance();
            builder.RegisterType<PaymentsViewModel>().AsSelf().SingleInstance();
            builder.RegisterType<MoreViewModel>().AsSelf().SingleInstance();
            builder.RegisterType<AccountViewModel>().AsSelf();
            builder.RegisterType<InstitutionSummaryViewModel>().AsSelf();
            builder.RegisterType<AccountDetailsViewModel>().AsSelf().SingleInstance();
        }

        public static void RegisterSplatAdapter(ContainerBuilder builder)
        {
            // Creates and sets the Autofac resolver as the Locator
            var autofacResolver = builder.UseAutofacDependencyResolver();

            // Register the resolver in Autofac so it can be later resolved
            builder.RegisterInstance(autofacResolver);

            // Initialize ReactiveUI components
            autofacResolver.InitializeReactiveUI();

            // If you need to override any service (such as the ViewLocator), register it after InitializeReactiveUI
            // https://autofaccn.readthedocs.io/en/latest/register/registration.html#default-registrations
            // builder.RegisterType<MyCustomViewLocator>().As<IViewLocator>().SingleInstance();
            
            // Make sure you set the application name before doing any inserts or gets
            Akavache.Registrations.Start("YapilyDemo");   
        }
        
        public static void SetLocatorLifetime(IContainer container)
        {
            var autofacResolver = container.Resolve<AutofacDependencyResolver>();

            // Set a lifetime scope (either the root or any of the child ones) to Autofac resolver
            // This is needed, because the previous steps did not Update the ContainerBuilder since they became immutable in Autofac 5+
            // https://github.com/autofac/Autofac/issues/811
            autofacResolver.SetLifetimeScope(container);
        }
    }
}