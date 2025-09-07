namespace Stripe.V2
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

    /// <summary>
    /// A pushed thin event.  Use this the Id with the <see cref="Stripe.V2.Core.EventService"/>
    /// exposed via <see cref="StripeClient"/> to fetch the full event.
    /// </summary>
    [JsonConverter(typeof(V2EventNotificationConverter))]
#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJV2EventNotificationConverter))]
#endif
    public class EventNotification
    {
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

        protected StripeClient? Client { get; set; }

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

        protected internal T FetchEvent<T>()
        where T : V2.Event
        {
            return this.FetchEventAsync<T>().ConfigureAwait(false).GetAwaiter().GetResult();
        }

        protected async Task<T> FetchEventAsync<T>(CancellationToken cancellationToken = default)
        where T : V2.Event
        {
            if (this.Client == null)
            {
                throw new Exception("EventNotification is trying to make a request with no client.");
            }

            return (T)await this.Client.V2.Core.Events.GetAsync(
                this.Id,
                requestOptions: new RequestOptions
                {
                    Usage = new List<string> { "fetch_event" },
                    StripeContext = this.Context,
                },
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        protected virtual T FetchRelatedObject<T>(EventNotificationRelatedObject relatedObject)
        where T : IStripeEntity
        {
            return this.FetchRelatedObjectAsync<T>(relatedObject).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        protected virtual async Task<T> FetchRelatedObjectAsync<T>(EventNotificationRelatedObject relatedObject, CancellationToken cancellationToken = default)
        where T : IStripeEntity
        {
            if (this.Client == null)
            {
                throw new Exception("EventNotification is trying to make a request with no client.");
            }

            var res = await this.Client.RawRequestAsync(
                HttpMethod.Get,
                relatedObject.Url,
                requestOptions: new RawRequestOptions
                {
                    Usage = new List<string> { "fetch_related_object" },
                    StripeContext = this.Context,
                },
                cancellationToken: cancellationToken)
            .ConfigureAwait(false);

            return this.Client.Deserialize<T>(res.Content);
        }
    }
}
