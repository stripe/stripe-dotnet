// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Treasury;

    public class OutboundPaymentService : Service<Stripe.Treasury.OutboundPayment>
    {
        public OutboundPaymentService()
        {
        }

        public OutboundPaymentService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/test_helpers/treasury/outbound_payments";

        /// <summary>
        /// <p>Transitions a test mode created OutboundPayment to the <c>failed</c> status. The
        /// OutboundPayment must already be in the <c>processing</c> state.</p>.
        /// </summary>
        public virtual Stripe.Treasury.OutboundPayment Fail(string id, OutboundPaymentFailOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Treasury.OutboundPayment>(HttpMethod.Post, $"/v1/test_helpers/treasury/outbound_payments/{id}/fail", options, requestOptions);
        }

        /// <summary>
        /// <p>Transitions a test mode created OutboundPayment to the <c>failed</c> status. The
        /// OutboundPayment must already be in the <c>processing</c> state.</p>.
        /// </summary>
        public virtual Task<Stripe.Treasury.OutboundPayment> FailAsync(string id, OutboundPaymentFailOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Treasury.OutboundPayment>(HttpMethod.Post, $"/v1/test_helpers/treasury/outbound_payments/{id}/fail", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Transitions a test mode created OutboundPayment to the <c>posted</c> status. The
        /// OutboundPayment must already be in the <c>processing</c> state.</p>.
        /// </summary>
        public virtual Stripe.Treasury.OutboundPayment Post(string id, OutboundPaymentPostOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Treasury.OutboundPayment>(HttpMethod.Post, $"/v1/test_helpers/treasury/outbound_payments/{id}/post", options, requestOptions);
        }

        /// <summary>
        /// <p>Transitions a test mode created OutboundPayment to the <c>posted</c> status. The
        /// OutboundPayment must already be in the <c>processing</c> state.</p>.
        /// </summary>
        public virtual Task<Stripe.Treasury.OutboundPayment> PostAsync(string id, OutboundPaymentPostOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Treasury.OutboundPayment>(HttpMethod.Post, $"/v1/test_helpers/treasury/outbound_payments/{id}/post", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Transitions a test mode created OutboundPayment to the <c>returned</c> status. The
        /// OutboundPayment must already be in the <c>processing</c> state.</p>.
        /// </summary>
        public virtual Stripe.Treasury.OutboundPayment ReturnOutboundPayment(string id, OutboundPaymentReturnOutboundPaymentOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Treasury.OutboundPayment>(HttpMethod.Post, $"/v1/test_helpers/treasury/outbound_payments/{id}/return", options, requestOptions);
        }

        /// <summary>
        /// <p>Transitions a test mode created OutboundPayment to the <c>returned</c> status. The
        /// OutboundPayment must already be in the <c>processing</c> state.</p>.
        /// </summary>
        public virtual Task<Stripe.Treasury.OutboundPayment> ReturnOutboundPaymentAsync(string id, OutboundPaymentReturnOutboundPaymentOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Treasury.OutboundPayment>(HttpMethod.Post, $"/v1/test_helpers/treasury/outbound_payments/{id}/return", options, requestOptions, cancellationToken);
        }
    }
}
