// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Issuing;

    public class CardService : Service<Stripe.Issuing.Card>
    {
        public CardService()
        {
        }

        public CardService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/test_helpers/issuing/cards";

        /// <summary>
        /// <p>Updates the shipping status of the specified Issuing <c>Card</c> object to
        /// <c>delivered</c>.</p>.
        /// </summary>
        public virtual Stripe.Issuing.Card DeliverCard(string id, CardDeliverCardOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Issuing.Card>(HttpMethod.Post, $"/v1/test_helpers/issuing/cards/{id}/shipping/deliver", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates the shipping status of the specified Issuing <c>Card</c> object to
        /// <c>delivered</c>.</p>.
        /// </summary>
        public virtual Task<Stripe.Issuing.Card> DeliverCardAsync(string id, CardDeliverCardOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Issuing.Card>(HttpMethod.Post, $"/v1/test_helpers/issuing/cards/{id}/shipping/deliver", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates the shipping status of the specified Issuing <c>Card</c> object to
        /// <c>failure</c>.</p>.
        /// </summary>
        public virtual Stripe.Issuing.Card FailCard(string id, CardFailCardOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Issuing.Card>(HttpMethod.Post, $"/v1/test_helpers/issuing/cards/{id}/shipping/fail", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates the shipping status of the specified Issuing <c>Card</c> object to
        /// <c>failure</c>.</p>.
        /// </summary>
        public virtual Task<Stripe.Issuing.Card> FailCardAsync(string id, CardFailCardOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Issuing.Card>(HttpMethod.Post, $"/v1/test_helpers/issuing/cards/{id}/shipping/fail", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates the shipping status of the specified Issuing <c>Card</c> object to
        /// <c>returned</c>.</p>.
        /// </summary>
        public virtual Stripe.Issuing.Card ReturnCard(string id, CardReturnCardOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Issuing.Card>(HttpMethod.Post, $"/v1/test_helpers/issuing/cards/{id}/shipping/return", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates the shipping status of the specified Issuing <c>Card</c> object to
        /// <c>returned</c>.</p>.
        /// </summary>
        public virtual Task<Stripe.Issuing.Card> ReturnCardAsync(string id, CardReturnCardOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Issuing.Card>(HttpMethod.Post, $"/v1/test_helpers/issuing/cards/{id}/shipping/return", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates the shipping status of the specified Issuing <c>Card</c> object to
        /// <c>shipped</c>.</p>.
        /// </summary>
        public virtual Stripe.Issuing.Card ShipCard(string id, CardShipCardOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Issuing.Card>(HttpMethod.Post, $"/v1/test_helpers/issuing/cards/{id}/shipping/ship", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates the shipping status of the specified Issuing <c>Card</c> object to
        /// <c>shipped</c>.</p>.
        /// </summary>
        public virtual Task<Stripe.Issuing.Card> ShipCardAsync(string id, CardShipCardOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Issuing.Card>(HttpMethod.Post, $"/v1/test_helpers/issuing/cards/{id}/shipping/ship", options, requestOptions, cancellationToken);
        }
    }
}
