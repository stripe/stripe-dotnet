// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
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

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/treasury/credit_reversals";

        public virtual CreditReversal Create(CreditReversalCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<CreditReversal>(HttpMethod.Post, $"/v1/treasury/credit_reversals", options, requestOptions);
        }

        public virtual Task<CreditReversal> CreateAsync(CreditReversalCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CreditReversal>(HttpMethod.Post, $"/v1/treasury/credit_reversals", options, requestOptions, cancellationToken);
        }

        public virtual CreditReversal Get(string id, CreditReversalGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<CreditReversal>(HttpMethod.Get, $"/v1/treasury/credit_reversals/{id}", options, requestOptions);
        }

        public virtual Task<CreditReversal> GetAsync(string id, CreditReversalGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CreditReversal>(HttpMethod.Get, $"/v1/treasury/credit_reversals/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<CreditReversal> List(CreditReversalListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<CreditReversal>>(HttpMethod.Get, $"/v1/treasury/credit_reversals", options, requestOptions);
        }

        public virtual Task<StripeList<CreditReversal>> ListAsync(CreditReversalListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<CreditReversal>>(HttpMethod.Get, $"/v1/treasury/credit_reversals", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<CreditReversal> ListAutoPaging(CreditReversalListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<CreditReversal>($"/v1/treasury/credit_reversals", options, requestOptions);
        }

        public virtual IAsyncEnumerable<CreditReversal> ListAutoPagingAsync(CreditReversalListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<CreditReversal>($"/v1/treasury/credit_reversals", options, requestOptions, cancellationToken);
        }
    }
}
