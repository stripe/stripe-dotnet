// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class EventService : Service
    {
        internal EventService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal EventService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Retrieves the details of an event.
        /// </summary>
        public virtual Event Get(string id, EventGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Event>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/events/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves the details of an event.
        /// </summary>
        public virtual Task<Event> GetAsync(string id, EventGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Event>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/events/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List events, going back up to 30 days.
        /// </summary>
        public virtual V2.StripeList<Event> List(EventListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<Event>>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/events", options, requestOptions);
        }

        /// <summary>
        /// List events, going back up to 30 days.
        /// </summary>
        public virtual Task<V2.StripeList<Event>> ListAsync(EventListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<Event>>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/events", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List events, going back up to 30 days.
        /// </summary>
        public virtual IEnumerable<Event> ListAutoPaging(EventListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Event>($"/v2/core/events", options, requestOptions);
        }

        /// <summary>
        /// List events, going back up to 30 days.
        /// </summary>
        public virtual IAsyncEnumerable<Event> ListAutoPagingAsync(EventListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Event>($"/v2/core/events", options, requestOptions, cancellationToken);
        }
    }
}
