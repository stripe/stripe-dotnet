// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Issuing;

    public class CardService : Service
    {
        public CardService()
        {
        }

        internal CardService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public CardService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Updates the shipping status of the specified Issuing <c>Card</c> object to
        /// <c>delivered</c>.</p>.
        /// </summary>
        public virtual Stripe.Issuing.Card DeliverCard(string id, CardDeliverCardOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Issuing.Card>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/issuing/cards/{WebUtility.UrlEncode(id)}/shipping/deliver", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates the shipping status of the specified Issuing <c>Card</c> object to
        /// <c>delivered</c>.</p>.
        /// </summary>
        public virtual Task<Stripe.Issuing.Card> DeliverCardAsync(string id, CardDeliverCardOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Issuing.Card>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/issuing/cards/{WebUtility.UrlEncode(id)}/shipping/deliver", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates the shipping status of the specified Issuing <c>Card</c> object to
        /// <c>failure</c>.</p>.
        /// </summary>
        public virtual Stripe.Issuing.Card FailCard(string id, CardFailCardOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Issuing.Card>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/issuing/cards/{WebUtility.UrlEncode(id)}/shipping/fail", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates the shipping status of the specified Issuing <c>Card</c> object to
        /// <c>failure</c>.</p>.
        /// </summary>
        public virtual Task<Stripe.Issuing.Card> FailCardAsync(string id, CardFailCardOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Issuing.Card>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/issuing/cards/{WebUtility.UrlEncode(id)}/shipping/fail", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates the shipping status of the specified Issuing <c>Card</c> object to
        /// <c>returned</c>.</p>.
        /// </summary>
        public virtual Stripe.Issuing.Card ReturnCard(string id, CardReturnCardOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Issuing.Card>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/issuing/cards/{WebUtility.UrlEncode(id)}/shipping/return", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates the shipping status of the specified Issuing <c>Card</c> object to
        /// <c>returned</c>.</p>.
        /// </summary>
        public virtual Task<Stripe.Issuing.Card> ReturnCardAsync(string id, CardReturnCardOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Issuing.Card>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/issuing/cards/{WebUtility.UrlEncode(id)}/shipping/return", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates the shipping status of the specified Issuing <c>Card</c> object to
        /// <c>shipped</c>.</p>.
        /// </summary>
        public virtual Stripe.Issuing.Card ShipCard(string id, CardShipCardOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Issuing.Card>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/issuing/cards/{WebUtility.UrlEncode(id)}/shipping/ship", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates the shipping status of the specified Issuing <c>Card</c> object to
        /// <c>shipped</c>.</p>.
        /// </summary>
        public virtual Task<Stripe.Issuing.Card> ShipCardAsync(string id, CardShipCardOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Issuing.Card>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/issuing/cards/{WebUtility.UrlEncode(id)}/shipping/ship", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates the shipping status of the specified Issuing <c>Card</c> object to
        /// <c>submitted</c>. This method requires Stripe Version ‘2024-09-30.acacia’ or later.</p>.
        /// </summary>
        public virtual Stripe.Issuing.Card SubmitCard(string id, CardSubmitCardOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Issuing.Card>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/issuing/cards/{WebUtility.UrlEncode(id)}/shipping/submit", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates the shipping status of the specified Issuing <c>Card</c> object to
        /// <c>submitted</c>. This method requires Stripe Version ‘2024-09-30.acacia’ or later.</p>.
        /// </summary>
        public virtual Task<Stripe.Issuing.Card> SubmitCardAsync(string id, CardSubmitCardOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Issuing.Card>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/issuing/cards/{WebUtility.UrlEncode(id)}/shipping/submit", options, requestOptions, cancellationToken);
        }
    }
}
