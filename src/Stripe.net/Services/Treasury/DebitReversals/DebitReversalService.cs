// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
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

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/treasury/debit_reversals";

        public virtual DebitReversal Create(DebitReversalCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<DebitReversal>(HttpMethod.Post, $"/v1/treasury/debit_reversals", options, requestOptions);
        }

        public virtual Task<DebitReversal> CreateAsync(DebitReversalCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<DebitReversal>(HttpMethod.Post, $"/v1/treasury/debit_reversals", options, requestOptions, cancellationToken);
        }

        public virtual DebitReversal Get(string id, DebitReversalGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<DebitReversal>(HttpMethod.Get, $"/v1/treasury/debit_reversals/{id}", options, requestOptions);
        }

        public virtual Task<DebitReversal> GetAsync(string id, DebitReversalGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<DebitReversal>(HttpMethod.Get, $"/v1/treasury/debit_reversals/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<DebitReversal> List(DebitReversalListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<DebitReversal>>(HttpMethod.Get, $"/v1/treasury/debit_reversals", options, requestOptions);
        }

        public virtual Task<StripeList<DebitReversal>> ListAsync(DebitReversalListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<DebitReversal>>(HttpMethod.Get, $"/v1/treasury/debit_reversals", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<DebitReversal> ListAutoPaging(DebitReversalListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<DebitReversal>($"/v1/treasury/debit_reversals", options, requestOptions);
        }

        public virtual IAsyncEnumerable<DebitReversal> ListAutoPagingAsync(DebitReversalListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<DebitReversal>($"/v1/treasury/debit_reversals", options, requestOptions, cancellationToken);
        }
    }
}
