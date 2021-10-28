using Appmilla.Yapily.Refit.Http;
using Autofac;
using Autofac.Extras.CommonServiceLocator;
using CommonServiceLocator;
using YapilyDemo.iOS.Services.Http;
using YapilyDemo.Services.Bootstrap;

namespace YapilyDemo.iOS.Services.Bootstrap
{
    public static class iOSBootstrapper
    {
        public static void Bootstrap()
        {
            var builder = new ContainerBuilder();

            // Perform registrations 
           
            var messageHandlerFactory = new MessageHandlerFactory();
            builder.Register(c => messageHandlerFactory).As<IMessageHandlerFactory>().SingleInstance();
            
            Bootstrapper.Bootstrap(builder);
            
            //builder.RegisterType<ViewModelLocator>().AsSelf().SingleInstance();
           
       
            //var completedFirstRun = Preferences.Get(UserKeys.UserHasCompletedFirstRun, false);
            //var requiresReauthentication = Preferences.Get(UserKeys.RequiresReauthentication, false);
            
            Bootstrapper.RegisterSplatAdapter(builder);
            
            //build the container
            var container = builder.Build();
            Bootstrapper.SetLocatorLifetime(container);
            
            // Set the service locator to an AutofacServiceLocator.
            var csl = new AutofacServiceLocator(container);
            ServiceLocator.SetLocatorProvider(() => csl);

            App.Container = container;
            
            Bootstrapper.PostContainerBuild();
            
            /*
            var secureStore = ServiceLocator.Current.GetInstance<ISecureStore>();
            
            MainThread.BeginInvokeOnMainThread(async () =>
            {
                if (!completedFirstRun)
                {
                    secureStore.Clear();
                }
            });
            */
        }
    }
}