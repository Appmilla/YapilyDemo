namespace Appmilla.Yapily.Refit.Queries
{
    public interface IInstituitionQuery
    {
        bool IsBusy { get; }

        IObservable<ICollection<Institution>> GetInstitutions(string cacheKey);

        IObservable<ICollection<Institution>> RefreshInstitutions(string cacheKey);
    }

    public class InstituitionQuery : ReactiveObject, IInstituitionQuery
    {
        readonly IBlobCache _blobCache;
        readonly IYapilyHttpClientFactory _httpClientFactory;
        readonly ISchedulerProvider _schedulerProvider;

        readonly TimeSpan _cacheLifetime = TimeSpan.FromHours(1);
        
        [Reactive] public bool IsBusy { get; set; }

        public AccountBalancesQuery(IBlobCache blobCache,
            IYapilyHttpClientFactory httpClientFactory,
            ISchedulerProvider schedulerProvider)
        {
            _blobCache = blobCache;
            _httpClientFactory = httpClientFactory;
            _schedulerProvider = schedulerProvider;
        }

        public IObservable<ICollection<Institution>> GetAccountBalances(string[] accountIds, string cacheKey)
        {
            DateTimeOffset? expiration = DateTimeOffset.Now + _cacheLifetime;

            return _blobCache.GetOrFetchObject(cacheKey,
                () => FetchAccountBalances(accountIds),
                expiration);
        }

        public IObservable<ICollection<Institution>> RefreshAccountBalances(string[] accountIds, string cacheKey)
        {
            return Observable.Create<ICollection<Institution>>(async observer =>
            {
                
                DateTimeOffset? expiration = DateTimeOffset.Now + _cacheLifetime;

                var history = await FetchAccountBalances(accountIds).ConfigureAwait(false);

                await _blobCache.InsertObject(cacheKey, history, expiration);

                observer.OnNext(history);

            }).SubscribeOn(_schedulerProvider.ThreadPool);
        }
        
        async Task<ICollection<Institution>> FetchAccountBalances(string[] accountIds)
        {
            IsBusy = true;

            try
            {
                var requestId = Guid.NewGuid().ToString();

                var httpClient = _httpClientFactory.CreateClient();

                var customerInfoClient = new CustomerInfoClient(httpClient);

                var allAccountBalances = await customerInfoClient.BalanceAsync(accountIds, requestId).ConfigureAwait(false);

                return allAccountBalances
                    .Where(x => x.ServiceType == ServiceType.Electricity ||
                        x.ServiceType == ServiceType.Gas).ToList();
            }
            finally
            {
                IsBusy = false;
            }  
        }
    }
}