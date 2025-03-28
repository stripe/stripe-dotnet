// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class EventDestinationService : Service
    {
        internal EventDestinationService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal EventDestinationService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Create a new event destination.
        /// </summary>
        public virtual V2.EventDestination Create(EventDestinationCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<V2.EventDestination>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/event_destinations", options, requestOptions);
        }

        /// <summary>
        /// Create a new event destination.
        /// </summary>
        public virtual Task<V2.EventDestination> CreateAsync(EventDestinationCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.EventDestination>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/event_destinations", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Delete an event destination.
        /// </summary>
        public virtual V2.EventDestination Delete(string id, EventDestinationDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.EventDestination>(BaseAddress.Api, HttpMethod.Delete, $"/v2/core/event_destinations/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Delete an event destination.
        /// </summary>
        public virtual Task<V2.EventDestination> DeleteAsync(string id, EventDestinationDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.EventDestination>(BaseAddress.Api, HttpMethod.Delete, $"/v2/core/event_destinations/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Disable an event destination.
        /// </summary>
        public virtual V2.EventDestination Disable(string id, EventDestinationDisableOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.EventDestination>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/event_destinations/{WebUtility.UrlEncode(id)}/disable", options, requestOptions);
        }

        /// <summary>
        /// Disable an event destination.
        /// </summary>
        public virtual Task<V2.EventDestination> DisableAsync(string id, EventDestinationDisableOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.EventDestination>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/event_destinations/{WebUtility.UrlEncode(id)}/disable", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Enable an event destination.
        /// </summary>
        public virtual V2.EventDestination Enable(string id, EventDestinationEnableOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.EventDestination>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/event_destinations/{WebUtility.UrlEncode(id)}/enable", options, requestOptions);
        }

        /// <summary>
        /// Enable an event destination.
        /// </summary>
        public virtual Task<V2.EventDestination> EnableAsync(string id, EventDestinationEnableOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.EventDestination>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/event_destinations/{WebUtility.UrlEncode(id)}/enable", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves the details of an event destination.
        /// </summary>
        public virtual V2.EventDestination Get(string id, EventDestinationGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.EventDestination>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/event_destinations/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves the details of an event destination.
        /// </summary>
        public virtual Task<V2.EventDestination> GetAsync(string id, EventDestinationGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.EventDestination>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/event_destinations/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Lists all event destinations.
        /// </summary>
        public virtual V2.StripeList<V2.EventDestination> List(EventDestinationListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<V2.EventDestination>>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/event_destinations", options, requestOptions);
        }

        /// <summary>
        /// Lists all event destinations.
        /// </summary>
        public virtual Task<V2.StripeList<V2.EventDestination>> ListAsync(EventDestinationListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<V2.EventDestination>>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/event_destinations", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Send a <c>ping</c> event to an event destination.
        /// </summary>
        public virtual V2.Event Ping(string id, EventDestinationPingOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.Event>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/event_destinations/{WebUtility.UrlEncode(id)}/ping", options, requestOptions);
        }

        /// <summary>
        /// Send a <c>ping</c> event to an event destination.
        /// </summary>
        public virtual Task<V2.Event> PingAsync(string id, EventDestinationPingOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.Event>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/event_destinations/{WebUtility.UrlEncode(id)}/ping", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Update the details of an event destination.
        /// </summary>
        public virtual V2.EventDestination Update(string id, EventDestinationUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<V2.EventDestination>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/event_destinations/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Update the details of an event destination.
        /// </summary>
        public virtual Task<V2.EventDestination> UpdateAsync(string id, EventDestinationUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.EventDestination>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/event_destinations/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
