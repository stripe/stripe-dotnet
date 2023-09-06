// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Issuing;

    public class CardService : Service<Card>
    {
        public CardService()
            : base(null)
        {
        }

        public CardService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/test_helpers/issuing/cards";

        public virtual Card DeliverCard(string id, CardDeliverCardOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/shipping/deliver", options, requestOptions);
        }

        public virtual Task<Card> DeliverCardAsync(string id, CardDeliverCardOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/shipping/deliver", options, requestOptions, cancellationToken);
        }

        public virtual Card FailCard(string id, CardFailCardOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/shipping/fail", options, requestOptions);
        }

        public virtual Task<Card> FailCardAsync(string id, CardFailCardOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/shipping/fail", options, requestOptions, cancellationToken);
        }

        public virtual Card ReturnCard(string id, CardReturnCardOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/shipping/return", options, requestOptions);
        }

        public virtual Task<Card> ReturnCardAsync(string id, CardReturnCardOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/shipping/return", options, requestOptions, cancellationToken);
        }

        public virtual Card ShipCard(string id, CardShipCardOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/shipping/ship", options, requestOptions);
        }

        public virtual Task<Card> ShipCardAsync(string id, CardShipCardOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/shipping/ship", options, requestOptions, cancellationToken);
        }
    }
}
