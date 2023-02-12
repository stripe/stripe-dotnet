// File generated from our OpenAPI spec
namespace Stripe.Capital
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class FinancingTransactionService : Service<FinancingTransaction>,
        IListable<FinancingTransaction, FinancingTransactionListOptions>,
        IRetrievable<FinancingTransaction, FinancingTransactionGetOptions>
    {
        public FinancingTransactionService()
            : base(null)
        {
        }

        public FinancingTransactionService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/capital/financing_transactions";

        public virtual FinancingTransaction Get(string id, FinancingTransactionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<FinancingTransaction> GetAsync(string id, FinancingTransactionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<FinancingTransaction> List(FinancingTransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<FinancingTransaction>> ListAsync(FinancingTransactionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<FinancingTransaction> ListAutoPaging(FinancingTransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual IAsyncEnumerable<FinancingTransaction> ListAutoPagingAsync(FinancingTransactionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }
    }
}
