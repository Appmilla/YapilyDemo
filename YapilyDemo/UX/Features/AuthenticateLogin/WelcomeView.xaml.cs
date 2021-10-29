using CommonServiceLocator;
using ReactiveUI;
using Xamarin.Forms.Xaml;

namespace YapilyDemo.UX.Features.AuthenticateLogin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomeView : IViewFor<WelcomeViewModel>
    {
        public WelcomeViewModel ViewModel { get; set; } = ServiceLocator.Current.GetInstance<WelcomeViewModel>();
        
        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => BindingContext = ViewModel = (WelcomeViewModel)value;
        }
        
        public WelcomeView()
        {
            InitializeComponent();
            
            BindingContext = ViewModel;
        }
    }
}