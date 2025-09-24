namespace Stripe
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    using Stripe.V2;

    /// <summary>
    /// A pushed thin event.  Use this the Id with the <see cref="Stripe.V2.Core.EventService"/>
    /// exposed via <see cref="StripeClient"/> to fetch the full event.
    /// </summary>
    public class ThinEvent
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
        public EventReason? Reason { get; internal set; }

        /// <summary>
        /// [Optional] Authentication context needed to fetch the event or related object.
        /// </summary>
        [JsonProperty("context")]
        [JsonConverter(typeof(Infrastructure.StripeContextConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("context")]
#endif
        public StripeContext? Context { get; internal set; }

        /// <summary>
        /// [Optional] Object containing the reference to API resource relevant to the event.
        /// </summary>
        [JsonProperty("related_object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("related_object")]
#endif
        public ThinEventRelatedObject? RelatedObject { get; internal set; }
    }
}
