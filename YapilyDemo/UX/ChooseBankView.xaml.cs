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