// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class EventService : Service<Event>,
        IListable<Event, EventListOptions>,
        IRetrievable<Event, EventGetOptions>
    {
        public EventService()
        {
        }

        public EventService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/events";

        /// <summary>
        /// <p>Retrieves the details of an event. Supply the unique identifier of the event, which
        /// you might have received in a webhook.</p>.
        /// </summary>
        public virtual Event Get(string id, EventGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Event>(HttpMethod.Get, $"/v1/events/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the details of an event. Supply the unique identifier of the event, which
        /// you might have received in a webhook.</p>.
        /// </summary>
        public virtual Task<Event> GetAsync(string id, EventGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Event>(HttpMethod.Get, $"/v1/events/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>List events, going back up to 30 days. Each event data is rendered according to
        /// Stripe API version at its creation time, specified in <a
        /// href="https://stripe.com/docs/api/events/object">event object</a> <c>api_version</c>
        /// attribute (not according to your current Stripe API version or <c>Stripe-Version</c>
        /// header).</p>.
        /// </summary>
        public virtual StripeList<Event> List(EventListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Event>>(HttpMethod.Get, $"/v1/events", options, requestOptions);
        }

        /// <summary>
        /// <p>List events, going back up to 30 days. Each event data is rendered according to
        /// Stripe API version at its creation time, specified in <a
        /// href="https://stripe.com/docs/api/events/object">event object</a> <c>api_version</c>
        /// attribute (not according to your current Stripe API version or <c>Stripe-Version</c>
        /// header).</p>.
        /// </summary>
        public virtual Task<StripeList<Event>> ListAsync(EventListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Event>>(HttpMethod.Get, $"/v1/events", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>List events, going back up to 30 days. Each event data is rendered according to
        /// Stripe API version at its creation time, specified in <a
        /// href="https://stripe.com/docs/api/events/object">event object</a> <c>api_version</c>
        /// attribute (not according to your current Stripe API version or <c>Stripe-Version</c>
        /// header).</p>.
        /// </summary>
        public virtual IEnumerable<Event> ListAutoPaging(EventListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Event>($"/v1/events", options, requestOptions);
        }

        /// <summary>
        /// <p>List events, going back up to 30 days. Each event data is rendered according to
        /// Stripe API version at its creation time, specified in <a
        /// href="https://stripe.com/docs/api/events/object">event object</a> <c>api_version</c>
        /// attribute (not according to your current Stripe API version or <c>Stripe-Version</c>
        /// header).</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Event> ListAutoPagingAsync(EventListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Event>($"/v1/events", options, requestOptions, cancellationToken);
        }
    }
}
