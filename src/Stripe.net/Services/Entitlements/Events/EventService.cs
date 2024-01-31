// File generated from our OpenAPI spec
namespace Stripe.Entitlements
{
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class EventService : Service<Event>,
        ICreatable<Event, EventCreateOptions>
    {
        public EventService()
            : base(null)
        {
        }

        public EventService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/entitlements/events";

        public virtual Event Create(EventCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Event>(HttpMethod.Post, $"/v1/entitlements/events", options, requestOptions);
        }

        public virtual Task<Event> CreateAsync(EventCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Event>(HttpMethod.Post, $"/v1/entitlements/events", options, requestOptions, cancellationToken);
        }
    }
}
