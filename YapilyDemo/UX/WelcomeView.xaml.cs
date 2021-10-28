using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonServiceLocator;
using ReactiveUI;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace YapilyDemo.UX
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