using CommonServiceLocator;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YapilyDemo.UX.Features.AccountDetails;
using YapilyDemo.UX.Features.ConnectBank;

namespace YapilyDemo.UX.Features.ApplicationShell
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        public AppShellViewModel ViewModel { get; set; } = ServiceLocator.Current.GetInstance<AppShellViewModel>();

        public AppShell()
        {
            InitializeComponent();

            BindingContext = ViewModel;

            Routing.RegisterRoute("chooseBank", typeof(ChooseBankView));
            Routing.RegisterRoute("accountDetails", typeof(AccountDetailsView));
        }
    }
}