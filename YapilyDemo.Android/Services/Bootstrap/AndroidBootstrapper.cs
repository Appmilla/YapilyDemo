using Appmilla.Yapily.Refit.Http;
using Autofac;
using Autofac.Extras.CommonServiceLocator;
using CommonServiceLocator;
using YapilyDemo.Droid.Services.Http;
using YapilyDemo.Services.Bootstrap;

namespace YapilyDemo.Droid.Services.Bootstrap
{
    public static class AndroidBootstrapper
    {
        public static IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();

            // Perform registrations and build the container.
            
            var messageHandlerFactory = new MessageHandlerFactory();
            builder.Register(c => messageHandlerFactory).As<IMessageHandlerFactory>().SingleInstance();
            
            Bootstrapper.Bootstrap(builder);
            
            //builder.RegisterType<ViewModelLocator>().AsSelf().SingleInstance();
            
            Bootstrapper.RegisterSplatAdapter(builder);
            
            // build the container
            var container = builder.Build();
            Bootstrapper.SetLocatorLifetime(container);
            
            // Set the service locator to an AutofacServiceLocator.
            var csl = new AutofacServiceLocator(container);
            ServiceLocator.SetLocatorProvider(() => csl);

            App.Container = container;

            Bootstrapper.PostContainerBuild();
            
            //var navigationViewService = ServiceLocator.Current.GetInstance<IViewRegistry>();
            //navigationViewService.SetRootViewModel(App.Locator.Main);

            return container;
        }
    }
}