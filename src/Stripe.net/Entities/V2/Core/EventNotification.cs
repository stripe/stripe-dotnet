namespace Stripe.V2.Core
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// An EventNotification, which is delivered to an Event Destination to tell you that an Event has happened.
    /// </summary>
    [JsonConverter(typeof(V2EventNotificationConverter))]
    [STJS.JsonConverter(typeof(STJV2EventNotificationConverter))]
    public class EventNotification
    {
        /// <summary>
        /// Unique identifier for the event.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; internal set; }

        /// <summary>
        /// The type of the event.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; internal set; }

        /// <summary>
        /// Time at which the object was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; internal set; }

        /// <summary>
        /// Livemode indicates if the event is from a production(true) or test(false) account.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; internal set; }

#nullable enable
        /// <summary>
        /// [Optional] Reason for the event.
        /// </summary>
        [JsonProperty("reason")]
        [STJS.JsonPropertyName("reason")]
        public EventNotificationReason? Reason { get; internal set; }

        /// <summary>
        /// [Optional] Authentication context needed to fetch the event or related object.
        /// </summary>
        [JsonProperty("context")]
        [STJS.JsonPropertyName("context")]
        public StripeContext? Context { get; internal set; }

        protected StripeClient? Client { get; set; }

        /// <summary>
        /// Helper for constructing an Event Notification. Doesn't perform signature validation, so you
        /// should use <see cref="StripeClient.ParseEventNotification"/> instead for
        /// initial handling. This is useful in unit tests and working with EventNotifications that you've
        /// already validated the authenticity of.
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
        where T : V2.Core.Event
        {
            return this.FetchEventAsync<T>().ConfigureAwait(false).GetAwaiter().GetResult();
        }

        protected async Task<T> FetchEventAsync<T>(CancellationToken cancellationToken = default)
        where T : V2.Core.Event
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
                    StripeRequestTrigger = $"event={this.Id}",
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
                    StripeRequestTrigger = $"event={this.Id}",
                },
                cancellationToken: cancellationToken)
            .ConfigureAwait(false);

            return this.Client.Deserialize<T>(res.Content);
        }
    }
}