namespace Stripe
{
    using System;
    using Newtonsoft.Json;
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
        public string Id { get; internal set; }

        /// <summary>
        /// The type of the event.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; internal set; }

        /// <summary>
        /// Time at which the object was created.
        /// </summary>
        [JsonProperty("created")]
        public DateTime Created { get; internal set; }

        /// <summary>
        /// Livemode indicates if the event is from a production(true) or test(false) account.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; internal set; }

#nullable enable
        /// <summary>
        /// [Optional] Reason for the event.
        /// </summary>
        [JsonProperty("reason")]
        public EventReason? Reason { get; internal set; }

        /// <summary>
        /// [Optional] Authentication context needed to fetch the event or related object.
        /// </summary>
        [JsonProperty("context")]
        public string? Context { get; internal set; }

        /// <summary>
        /// [Optional] Object containing the reference to API resource relevant to the event.
        /// </summary>
        [JsonProperty("related_object")]
        public ThinEventRelatedObject? RelatedObject { get; internal set; }
    }
}
