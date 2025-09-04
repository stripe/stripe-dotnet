namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    using Stripe.V2;

    /// <summary>
    /// A pushed thin event.  Use this the Id with the <see cref="Stripe.V2.Core.EventService"/>
    /// exposed via <see cref="StripeClient"/> to fetch the full event.
    /// </summary>
    public abstract class EventNotification
    {
        // not actually used, but needed for the compiler.
        private EventNotification(StripeClient client)
        {
            this.Client = client;
        }

        /// <summary>
        /// Unique identifier for the event.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; internal set; }

        /// <summary>
        /// The type of the event.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; internal set; }

        /// <summary>
        /// Time at which the object was created.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public DateTime Created { get; internal set; }

        /// <summary>
        /// Livemode indicates if the event is from a production(true) or test(false) account.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; internal set; }

#nullable enable
        /// <summary>
        /// [Optional] Reason for the event.
        /// </summary>
        [JsonProperty("reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reason")]
#endif
        public EventNotificationReason? Reason { get; internal set; }

        /// <summary>
        /// [Optional] Authentication context needed to fetch the event or related object.
        /// </summary>
        [JsonProperty("context")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("context")]
#endif
        public string? Context { get; internal set; }

        protected StripeClient Client { get; set; }

        /// <summary>
        /// Not suitable for production code because it doesn't validate event signature. It's used internally for testing and from StripeClient.
        /// </summary>
        /// <param name="payload">JSON body for an EventNotification.</param>
        /// <param name="client">A StripeClient instance that will be used to make requests.</param>
        /// <returns></returns>
        public static EventNotification FromJson(string payload, StripeClient client)
        {
            var en = JsonUtils.DeserializeObject<EventNotification>(payload, client.GetJsonSerializationSettings());

            en.Client = client;

            return en;
        }

        private RequestOptions GetRequestOptions(string usage)
        {
            var o = new RequestOptions { Usage = new List<string> { usage } };
            if (this.Context != null)
            {
                o.StripeContext = this.Context;
            }

            return o;
        }

        private RawRequestOptions GetRawRequestOptions(string usage)
        {
            var o = new RawRequestOptions { Usage = new List<string> { usage } };
            if (this.Context != null)
            {
                o.StripeContext = this.Context;
            }

            return o;
        }

        protected V2.Event FetchEvent()
        {
            return this.FetchEventAsync().ConfigureAwait(false).GetAwaiter().GetResult();
        }

        protected Task<V2.Event> FetchEventAsync(CancellationToken cancellationToken = default)
        {
            return this.Client.V2.Core.Events.GetAsync(this.Id, requestOptions: this.GetRequestOptions("fetch_event"), cancellationToken: cancellationToken);
        }

        protected virtual async Task<T> FetchRelatedObjectAsync<T>(EventNotificationRelatedObject relatedObject, CancellationToken cancellationToken = default)
        where T : IStripeEntity
        {
            if (relatedObject == null)
            {
                return null;
            }

            var res = await this.Client.RawRequestAsync(HttpMethod.Get, relatedObject.Url, requestOptions: this.GetRawRequestOptions("fetch_related_object"), cancellationToken: cancellationToken).ConfigureAwait(true);

            return this.Client.Deserialize<T>(res.Content);
        }
    }
}
