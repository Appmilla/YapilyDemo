using CommonServiceLocator;
using ReactiveUI;
using Xamarin.Forms.Xaml;

namespace YapilyDemo.UX
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MoreView : IViewFor<MoreViewModel>
    {
        public MoreViewModel ViewModel { get; set; } = ServiceLocator.Current.GetInstance<MoreViewModel>();

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => BindingContext = ViewModel = (MoreViewModel)value;
        }

        public MoreView()
        {
            InitializeComponent();

            BindingContext = ViewModel;
        }
    }
}
