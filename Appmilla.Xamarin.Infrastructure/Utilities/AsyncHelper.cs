using System;
using System.Reactive.Linq;
using System.Threading.Tasks;

namespace Appmilla.Xamarin.Infrastructure.Utilities
{
    public static class AsyncHelper
    {
        public static TResult RunSync<TResult>(Func<Task<TResult>> func) => _ = Observable.StartAsync(func).GetAwaiter().GetResult();
        public static void RunSync(Func<Task> func) => Observable.StartAsync(func).GetAwaiter().GetResult();
    }
}