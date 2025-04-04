// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class DebitReversalService : Service,
        ICreatable<DebitReversal, DebitReversalCreateOptions>,
        IListable<DebitReversal, DebitReversalListOptions>,
        IRetrievable<DebitReversal, DebitReversalGetOptions>
    {
        public DebitReversalService()
        {
        }

        internal DebitReversalService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public DebitReversalService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Reverses a ReceivedDebit and creates a DebitReversal object.</p>.
        /// </summary>
        public virtual DebitReversal Create(DebitReversalCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<DebitReversal>(BaseAddress.Api, HttpMethod.Post, $"/v1/treasury/debit_reversals", options, requestOptions);
        }

        /// <summary>
        /// <p>Reverses a ReceivedDebit and creates a DebitReversal object.</p>.
        /// </summary>
        public virtual Task<DebitReversal> CreateAsync(DebitReversalCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<DebitReversal>(BaseAddress.Api, HttpMethod.Post, $"/v1/treasury/debit_reversals", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves a DebitReversal object.</p>.
        /// </summary>
        public virtual DebitReversal Get(string id, DebitReversalGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<DebitReversal>(BaseAddress.Api, HttpMethod.Get, $"/v1/treasury/debit_reversals/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a DebitReversal object.</p>.
        /// </summary>
        public virtual Task<DebitReversal> GetAsync(string id, DebitReversalGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<DebitReversal>(BaseAddress.Api, HttpMethod.Get, $"/v1/treasury/debit_reversals/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of DebitReversals.</p>.
        /// </summary>
        public virtual StripeList<DebitReversal> List(DebitReversalListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<DebitReversal>>(BaseAddress.Api, HttpMethod.Get, $"/v1/treasury/debit_reversals", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of DebitReversals.</p>.
        /// </summary>
        public virtual Task<StripeList<DebitReversal>> ListAsync(DebitReversalListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<DebitReversal>>(BaseAddress.Api, HttpMethod.Get, $"/v1/treasury/debit_reversals", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of DebitReversals.</p>.
        /// </summary>
        public virtual IEnumerable<DebitReversal> ListAutoPaging(DebitReversalListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<DebitReversal>($"/v1/treasury/debit_reversals", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of DebitReversals.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<DebitReversal> ListAutoPagingAsync(DebitReversalListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<DebitReversal>($"/v1/treasury/debit_reversals", options, requestOptions, cancellationToken);
        }
    }
}
