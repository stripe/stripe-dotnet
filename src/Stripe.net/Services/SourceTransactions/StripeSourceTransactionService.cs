using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeSourceTransactionService : StripeBasicService<StripeSourceTransaction>
    {
        public StripeSourceTransactionService() : base(null) { }
        public StripeSourceTransactionService(string apiKey) : base(apiKey) { }



        // Sync
        public virtual StripeList<StripeSourceTransaction> List(string sourceId, StripeSourceTransactionsListOptions options = null, StripeRequestOptions requestOptions = null)
        {
            return GetEntityList($"{Urls.BaseUrl}/sources/{sourceId}/source_transactions", requestOptions, options);
        }



        // Async
        public virtual Task<StripeList<StripeSourceTransaction>> ListAsync(string sourceId, StripeSourceTransactionsListOptions options = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetEntityListAsync($"{Urls.BaseUrl}/sources/{sourceId}/source_transactions", requestOptions, cancellationToken, options);
        }
    }
}
