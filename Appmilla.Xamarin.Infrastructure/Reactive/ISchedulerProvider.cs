using System.Reactive.Concurrency;

namespace Appmilla.Xamarin.Infrastructure.Reactive
{
    public interface ISchedulerProvider
    {
        IScheduler MainThread { get; }
        IScheduler ThreadPool { get; }
    }
}