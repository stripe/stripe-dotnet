namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class BalanceTransactionService : Service<BalanceTransaction>,
        IListable<BalanceTransaction, BalanceTransactionListOptions>,
        IRetrievable<BalanceTransaction>
    {
        public BalanceTransactionService()
            : base(null)
        {
        }

        public BalanceTransactionService(string apiKey)
            : base(apiKey)
        {
        }

        public override string BasePath => "/v1/balance/history";

        public bool ExpandSource { get; set; }

        public virtual BalanceTransaction Get(string balanceTransactionId, RequestOptions requestOptions = null)
        {
            return this.GetEntity(balanceTransactionId, null, requestOptions);
        }

        public virtual Task<BalanceTransaction> GetAsync(string balanceTransactionId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(balanceTransactionId, null, requestOptions, cancellationToken);
        }

        public virtual StripeList<BalanceTransaction> List(BalanceTransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<BalanceTransaction>> ListAsync(BalanceTransactionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<BalanceTransaction> ListAutoPaging(BalanceTransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }
    }
}
