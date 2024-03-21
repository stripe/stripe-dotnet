// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Terminal
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Terminal;

    public class ReaderService : Service<Stripe.Terminal.Reader>
    {
        public ReaderService()
        {
        }

        public ReaderService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/test_helpers/terminal/readers";

        /// <summary>
        /// <p>Presents a payment method on a simulated reader. Can be used to simulate accepting a
        /// payment, saving a card or refunding a transaction.</p>.
        /// </summary>
        public virtual Stripe.Terminal.Reader PresentPaymentMethod(string id, ReaderPresentPaymentMethodOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Terminal.Reader>(HttpMethod.Post, $"/v1/test_helpers/terminal/readers/{id}/present_payment_method", options, requestOptions);
        }

        /// <summary>
        /// <p>Presents a payment method on a simulated reader. Can be used to simulate accepting a
        /// payment, saving a card or refunding a transaction.</p>.
        /// </summary>
        public virtual Task<Stripe.Terminal.Reader> PresentPaymentMethodAsync(string id, ReaderPresentPaymentMethodOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Terminal.Reader>(HttpMethod.Post, $"/v1/test_helpers/terminal/readers/{id}/present_payment_method", options, requestOptions, cancellationToken);
        }
    }
}
