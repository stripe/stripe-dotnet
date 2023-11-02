// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class EventService : Service<Event>,
        IListable<Event, EventListOptions>,
        IRetrievable<Event, EventGetOptions>
    {
        public EventService()
            : base(null)
        {
        }

        public EventService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/events";

        public virtual Event Get(string id, EventGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Event>(HttpMethod.Get, $"/v1/events/{id}", options, requestOptions);
        }

        public virtual Task<Event> GetAsync(string id, EventGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Event>(HttpMethod.Get, $"/v1/events/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Event> List(EventListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Event>>(HttpMethod.Get, $"/v1/events", options, requestOptions);
        }

        public virtual Task<StripeList<Event>> ListAsync(EventListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Event>>(HttpMethod.Get, $"/v1/events", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Event> ListAutoPaging(EventListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Event>($"/v1/events", options, requestOptions);
        }

        public virtual IAsyncEnumerable<Event> ListAutoPagingAsync(EventListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Event>($"/v1/events", options, requestOptions, cancellationToken);
        }
    }
}
