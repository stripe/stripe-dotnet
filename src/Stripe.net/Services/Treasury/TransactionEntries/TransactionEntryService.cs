// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class TransactionEntryService : Service<TransactionEntry>,
        IListable<TransactionEntry, TransactionEntryListOptions>,
        IRetrievable<TransactionEntry, TransactionEntryGetOptions>
    {
        public TransactionEntryService()
            : base(null)
        {
        }

        public TransactionEntryService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/treasury/transaction_entries";

        public virtual TransactionEntry Get(string id, TransactionEntryGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<TransactionEntry> GetAsync(string id, TransactionEntryGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<TransactionEntry> List(TransactionEntryListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<TransactionEntry>> ListAsync(TransactionEntryListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<TransactionEntry> ListAutoPaging(TransactionEntryListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual IAsyncEnumerable<TransactionEntry> ListAutoPagingAsync(TransactionEntryListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }
    }
}
