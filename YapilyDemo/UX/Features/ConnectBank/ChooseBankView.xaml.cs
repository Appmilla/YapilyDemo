using CommonServiceLocator;
using ReactiveUI;
using Xamarin.Forms.Xaml;

namespace YapilyDemo.UX.Features.ConnectBank
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChooseBankView : IViewFor<ChooseBankViewModel>
    {
        public ChooseBankViewModel ViewModel { get; set; } = ServiceLocator.Current.GetInstance<ChooseBankViewModel>();
        
        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => BindingContext = ViewModel = (ChooseBankViewModel)value;
        }
        
        public ChooseBankView()
        {
            InitializeComponent();
            
            BindingContext = ViewModel;
        }
    }
}