// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class CreditReversalService : Service<CreditReversal>,
        ICreatable<CreditReversal, CreditReversalCreateOptions>,
        IListable<CreditReversal, CreditReversalListOptions>,
        IRetrievable<CreditReversal, CreditReversalGetOptions>
    {
        public CreditReversalService()
            : base(null)
        {
        }

        public CreditReversalService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/treasury/credit_reversals";

        public virtual CreditReversal Create(CreditReversalCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<CreditReversal> CreateAsync(CreditReversalCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual CreditReversal Get(string id, CreditReversalGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<CreditReversal> GetAsync(string id, CreditReversalGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<CreditReversal> List(CreditReversalListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<CreditReversal>> ListAsync(CreditReversalListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<CreditReversal> ListAutoPaging(CreditReversalListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual IAsyncEnumerable<CreditReversal> ListAutoPagingAsync(CreditReversalListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }
    }
}
