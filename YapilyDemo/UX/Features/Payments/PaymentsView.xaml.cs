using CommonServiceLocator;
using ReactiveUI;
using Xamarin.Forms.Xaml;

namespace YapilyDemo.UX.Features.Payments
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaymentsView : IViewFor<PaymentsViewModel>
    {
        public PaymentsViewModel ViewModel { get; set; } = ServiceLocator.Current.GetInstance<PaymentsViewModel>();

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => BindingContext = ViewModel = (PaymentsViewModel)value;
        }

        public PaymentsView()
        {
            InitializeComponent();

            BindingContext = ViewModel;
        }
    }
}
