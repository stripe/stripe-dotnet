// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Terminal
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Terminal;

    public class ReaderService : Service
    {
        public ReaderService()
        {
        }

        internal ReaderService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public ReaderService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Presents a payment method on a simulated reader. Can be used to simulate accepting a
        /// payment, saving a card or refunding a transaction.</p>.
        /// </summary>
        public virtual Stripe.Terminal.Reader PresentPaymentMethod(string id, ReaderPresentPaymentMethodOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Terminal.Reader>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/terminal/readers/{WebUtility.UrlEncode(id)}/present_payment_method", options, requestOptions);
        }

        /// <summary>
        /// <p>Presents a payment method on a simulated reader. Can be used to simulate accepting a
        /// payment, saving a card or refunding a transaction.</p>.
        /// </summary>
        public virtual Task<Stripe.Terminal.Reader> PresentPaymentMethodAsync(string id, ReaderPresentPaymentMethodOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Terminal.Reader>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/terminal/readers/{WebUtility.UrlEncode(id)}/present_payment_method", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Use this endpoint to trigger a successful input collection on a simulated reader.</p>.
        /// </summary>
        public virtual Stripe.Terminal.Reader SucceedInputCollection(string id, ReaderSucceedInputCollectionOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Terminal.Reader>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/terminal/readers/{WebUtility.UrlEncode(id)}/succeed_input_collection", options, requestOptions);
        }

        /// <summary>
        /// <p>Use this endpoint to trigger a successful input collection on a simulated reader.</p>.
        /// </summary>
        public virtual Task<Stripe.Terminal.Reader> SucceedInputCollectionAsync(string id, ReaderSucceedInputCollectionOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Terminal.Reader>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/terminal/readers/{WebUtility.UrlEncode(id)}/succeed_input_collection", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Use this endpoint to complete an input collection with a timeout error on a simulated
        /// reader.</p>.
        /// </summary>
        public virtual Stripe.Terminal.Reader TimeoutInputCollection(string id, ReaderTimeoutInputCollectionOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Terminal.Reader>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/terminal/readers/{WebUtility.UrlEncode(id)}/timeout_input_collection", options, requestOptions);
        }

        /// <summary>
        /// <p>Use this endpoint to complete an input collection with a timeout error on a simulated
        /// reader.</p>.
        /// </summary>
        public virtual Task<Stripe.Terminal.Reader> TimeoutInputCollectionAsync(string id, ReaderTimeoutInputCollectionOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Terminal.Reader>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/terminal/readers/{WebUtility.UrlEncode(id)}/timeout_input_collection", options, requestOptions, cancellationToken);
        }
    }
}
