using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeBalanceService : StripeBasicService<StripeBalance>
    {
        public StripeBalanceService(string apiKey = null) : base(apiKey) { }



        //Sync
        public virtual StripeBalance Get(StripeRequestOptions requestOptions = null)
        {
            return GetEntity($"{Urls.BaseUrl}/balance", requestOptions);
        }

        public virtual StripeBalanceTransaction Get(string id, StripeRequestOptions requestOptions = null)
        {
            return GetEntity($"{Urls.BaseUrl}/balance/history/{id}", requestOptions);
        }

        public virtual IEnumerable<StripeBalanceTransaction> List(StripeBalanceTransactionListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return GetEntityList($"{Urls.BaseUrl}/balance/history", requestOptions, listOptions);
        }



        //Async
        public virtual async Task<StripeBalance> GetAsync(StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetEntityAsync($"{Urls.BaseUrl}/balance", requestOptions, cancellationToken);
        }

        public virtual async Task<StripeBalanceTransaction> GetAsync(string id, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetEntityAsync($"{Urls.BaseUrl}/balance/history/{id}", requestOptions, cancellationToken);
        }

        public virtual async Task<IEnumerable<StripeBalanceTransaction>> ListAsync(StripeBalanceTransactionListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetEntityListAsync($"{Urls.BaseUrl}/balance/history", requestOptions, cancellationToken, listOptions);
        }
    }
}
