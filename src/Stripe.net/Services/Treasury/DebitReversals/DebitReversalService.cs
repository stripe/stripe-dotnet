// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class DebitReversalService : Service<DebitReversal>,
        ICreatable<DebitReversal, DebitReversalCreateOptions>,
        IListable<DebitReversal, DebitReversalListOptions>,
        IRetrievable<DebitReversal, DebitReversalGetOptions>
    {
        public DebitReversalService()
            : base(null)
        {
        }

        public DebitReversalService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/treasury/debit_reversals";

        public virtual DebitReversal Create(DebitReversalCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<DebitReversal> CreateAsync(DebitReversalCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual DebitReversal Get(string id, DebitReversalGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<DebitReversal> GetAsync(string id, DebitReversalGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<DebitReversal> List(DebitReversalListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<DebitReversal>> ListAsync(DebitReversalListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<DebitReversal> ListAutoPaging(DebitReversalListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual IAsyncEnumerable<DebitReversal> ListAutoPagingAsync(DebitReversalListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }
    }
}
