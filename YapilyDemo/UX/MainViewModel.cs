using Appmilla.Xamarin.Infrastructure.Reactive;
using ReactiveUI;
using YapilyDemo.Framework;

namespace YapilyDemo.UX
{
    public class MainViewModel : ReactiveObject, IViewModel
    {
        public string Id => NavigationPageKeys.MainPageKey;
        
        public MainViewModel()
        {
            
        }
    }
}