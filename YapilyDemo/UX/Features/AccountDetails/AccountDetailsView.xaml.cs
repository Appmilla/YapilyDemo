using CommonServiceLocator;
using ReactiveUI;
using Xamarin.Forms.Xaml;

namespace YapilyDemo.UX.Features.AccountDetails
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccountDetailsView : IViewFor<AccountDetailsViewModel>
    {
        public AccountDetailsViewModel ViewModel { get; set; } = ServiceLocator.Current.GetInstance<AccountDetailsViewModel>();

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => BindingContext = ViewModel = (AccountDetailsViewModel)value;
        }
        
        public AccountDetailsView()
        {
            InitializeComponent();
            
            BindingContext = ViewModel;
        }
    }
}