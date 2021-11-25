using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonServiceLocator;
using ReactiveUI;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace YapilyDemo.UX.Features.Payments
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreatePaymentView : IViewFor<CreatePaymentViewModel>
    {
        public CreatePaymentViewModel ViewModel { get; set; } = ServiceLocator.Current.GetInstance<CreatePaymentViewModel>();
        
        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => BindingContext = ViewModel = (CreatePaymentViewModel)value;
        }
        
        public CreatePaymentView()
        {
            InitializeComponent();
            
            BindingContext = ViewModel;
        }
    }
}