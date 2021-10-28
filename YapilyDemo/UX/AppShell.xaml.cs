using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonServiceLocator;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace YapilyDemo.UX
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
        }
    }
}