using CommonServiceLocator;
using ReactiveUI;
using Xamarin.Forms.Xaml;

namespace YapilyDemo.UX.Features.Home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeView : IViewFor<HomeViewModel>
    {
        public HomeViewModel ViewModel { get; set; } = ServiceLocator.Current.GetInstance<HomeViewModel>();

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => BindingContext = ViewModel = (HomeViewModel)value;
        }

        public HomeView()
        {
            InitializeComponent();

            BindingContext = ViewModel;
        }
    }
}
