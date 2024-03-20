// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Treasury;

    public class OutboundTransferService : Service<Stripe.Treasury.OutboundTransfer>
    {
        public OutboundTransferService()
        {
        }

        public OutboundTransferService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/test_helpers/treasury/outbound_transfers";

        /// <summary>
        /// <p>Transitions a test mode created OutboundTransfer to the <c>failed</c> status. The
        /// OutboundTransfer must already be in the <c>processing</c> state.</p>.
        /// </summary>
        public virtual Stripe.Treasury.OutboundTransfer Fail(string id, OutboundTransferFailOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Treasury.OutboundTransfer>(HttpMethod.Post, $"/v1/test_helpers/treasury/outbound_transfers/{id}/fail", options, requestOptions);
        }

        /// <summary>
        /// <p>Transitions a test mode created OutboundTransfer to the <c>failed</c> status. The
        /// OutboundTransfer must already be in the <c>processing</c> state.</p>.
        /// </summary>
        public virtual Task<Stripe.Treasury.OutboundTransfer> FailAsync(string id, OutboundTransferFailOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Treasury.OutboundTransfer>(HttpMethod.Post, $"/v1/test_helpers/treasury/outbound_transfers/{id}/fail", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Transitions a test mode created OutboundTransfer to the <c>posted</c> status. The
        /// OutboundTransfer must already be in the <c>processing</c> state.</p>.
        /// </summary>
        public virtual Stripe.Treasury.OutboundTransfer Post(string id, OutboundTransferPostOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Treasury.OutboundTransfer>(HttpMethod.Post, $"/v1/test_helpers/treasury/outbound_transfers/{id}/post", options, requestOptions);
        }

        /// <summary>
        /// <p>Transitions a test mode created OutboundTransfer to the <c>posted</c> status. The
        /// OutboundTransfer must already be in the <c>processing</c> state.</p>.
        /// </summary>
        public virtual Task<Stripe.Treasury.OutboundTransfer> PostAsync(string id, OutboundTransferPostOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Treasury.OutboundTransfer>(HttpMethod.Post, $"/v1/test_helpers/treasury/outbound_transfers/{id}/post", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Transitions a test mode created OutboundTransfer to the <c>returned</c> status. The
        /// OutboundTransfer must already be in the <c>processing</c> state.</p>.
        /// </summary>
        public virtual Stripe.Treasury.OutboundTransfer ReturnOutboundTransfer(string id, OutboundTransferReturnOutboundTransferOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Treasury.OutboundTransfer>(HttpMethod.Post, $"/v1/test_helpers/treasury/outbound_transfers/{id}/return", options, requestOptions);
        }

        /// <summary>
        /// <p>Transitions a test mode created OutboundTransfer to the <c>returned</c> status. The
        /// OutboundTransfer must already be in the <c>processing</c> state.</p>.
        /// </summary>
        public virtual Task<Stripe.Treasury.OutboundTransfer> ReturnOutboundTransferAsync(string id, OutboundTransferReturnOutboundTransferOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Treasury.OutboundTransfer>(HttpMethod.Post, $"/v1/test_helpers/treasury/outbound_transfers/{id}/return", options, requestOptions, cancellationToken);
        }
    }
}
