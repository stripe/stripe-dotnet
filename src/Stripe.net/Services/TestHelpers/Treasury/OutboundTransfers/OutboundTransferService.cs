// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Treasury;

    public class OutboundTransferService : Service
    {
        public OutboundTransferService()
        {
        }

        internal OutboundTransferService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public OutboundTransferService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Transitions a test <c>OutboundTransfer</c> to the <c>failed</c> status. The
        /// <c>OutboundTransfer</c> must already be in the <c>processing</c> state.</p>.
        /// </summary>
        public virtual Stripe.Treasury.OutboundTransfer Fail(string id, OutboundTransferFailOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Treasury.OutboundTransfer>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/treasury/outbound_transfers/{WebUtility.UrlEncode(id)}/fail", options, requestOptions);
        }

        /// <summary>
        /// <p>Transitions a test <c>OutboundTransfer</c> to the <c>failed</c> status. The
        /// <c>OutboundTransfer</c> must already be in the <c>processing</c> state.</p>.
        /// </summary>
        public virtual Task<Stripe.Treasury.OutboundTransfer> FailAsync(string id, OutboundTransferFailOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Treasury.OutboundTransfer>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/treasury/outbound_transfers/{WebUtility.UrlEncode(id)}/fail", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Transitions a test <c>OutboundTransfer</c> to the <c>posted</c> status. The
        /// <c>OutboundTransfer</c> must already be in the <c>processing</c> state.</p>.
        /// </summary>
        public virtual Stripe.Treasury.OutboundTransfer Post(string id, OutboundTransferPostOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Treasury.OutboundTransfer>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/treasury/outbound_transfers/{WebUtility.UrlEncode(id)}/post", options, requestOptions);
        }

        /// <summary>
        /// <p>Transitions a test <c>OutboundTransfer</c> to the <c>posted</c> status. The
        /// <c>OutboundTransfer</c> must already be in the <c>processing</c> state.</p>.
        /// </summary>
        public virtual Task<Stripe.Treasury.OutboundTransfer> PostAsync(string id, OutboundTransferPostOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Treasury.OutboundTransfer>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/treasury/outbound_transfers/{WebUtility.UrlEncode(id)}/post", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Transitions a test <c>OutboundTransfer</c> to the <c>returned</c> status. The
        /// <c>OutboundTransfer</c> must already be in the <c>posted</c> state.</p>.
        /// </summary>
        public virtual Stripe.Treasury.OutboundTransfer ReturnOutboundTransfer(string id, OutboundTransferReturnOutboundTransferOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Treasury.OutboundTransfer>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/treasury/outbound_transfers/{WebUtility.UrlEncode(id)}/return", options, requestOptions);
        }

        /// <summary>
        /// <p>Transitions a test <c>OutboundTransfer</c> to the <c>returned</c> status. The
        /// <c>OutboundTransfer</c> must already be in the <c>posted</c> state.</p>.
        /// </summary>
        public virtual Task<Stripe.Treasury.OutboundTransfer> ReturnOutboundTransferAsync(string id, OutboundTransferReturnOutboundTransferOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Treasury.OutboundTransfer>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/treasury/outbound_transfers/{WebUtility.UrlEncode(id)}/return", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates a test <c>OutboundTransfer</c> with tracking details. The
        /// <c>OutboundTransfer</c> must not be cancelable, and can’t be in the <c>canceled</c> or
        /// <c>failed</c> states.</p>.
        /// </summary>
        public virtual Stripe.Treasury.OutboundTransfer Update(string id, OutboundTransferUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Treasury.OutboundTransfer>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/treasury/outbound_transfers/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates a test <c>OutboundTransfer</c> with tracking details. The
        /// <c>OutboundTransfer</c> must not be cancelable, and can’t be in the <c>canceled</c> or
        /// <c>failed</c> states.</p>.
        /// </summary>
        public virtual Task<Stripe.Treasury.OutboundTransfer> UpdateAsync(string id, OutboundTransferUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Treasury.OutboundTransfer>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/treasury/outbound_transfers/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
