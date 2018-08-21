namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class SourceTransactionService : BasicService<SourceTransaction>
    {
        public SourceTransactionService()
            : base(null)
        {
        }

        public SourceTransactionService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual StripeList<SourceTransaction> List(string sourceId, SourceTransactionsListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{Urls.BaseUrl}/sources/{sourceId}/source_transactions", requestOptions, options);
        }

        public virtual Task<StripeList<SourceTransaction>> ListAsync(string sourceId, SourceTransactionsListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{Urls.BaseUrl}/sources/{sourceId}/source_transactions", requestOptions, cancellationToken, options);
        }
    }
}
