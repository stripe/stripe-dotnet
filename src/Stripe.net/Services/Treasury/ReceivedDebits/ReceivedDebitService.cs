// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class ReceivedDebitService : Service<ReceivedDebit>,
        IListable<ReceivedDebit, ReceivedDebitListOptions>,
        IRetrievable<ReceivedDebit, ReceivedDebitGetOptions>
    {
        public ReceivedDebitService()
            : base(null)
        {
        }

        public ReceivedDebitService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/treasury/received_debits";

        public virtual ReceivedDebit Get(string id, ReceivedDebitGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<ReceivedDebit> GetAsync(string id, ReceivedDebitGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<ReceivedDebit> List(ReceivedDebitListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<ReceivedDebit>> ListAsync(ReceivedDebitListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<ReceivedDebit> ListAutoPaging(ReceivedDebitListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual IAsyncEnumerable<ReceivedDebit> ListAutoPagingAsync(ReceivedDebitListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }
    }
}
