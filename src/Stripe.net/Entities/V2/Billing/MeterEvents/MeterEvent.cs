// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Fix me empty_doc_string.
    /// </summary>
    public class MeterEvent : StripeEntity<MeterEvent>, IHasObject
    {
        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// The creation time of this meter event.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The name of the meter event. Corresponds with the <c>event_name</c> field on a meter.
        /// </summary>
        [JsonProperty("event_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("event_name")]
#endif
        public string EventName { get; set; }

        /// <summary>
        /// A unique identifier for the event. If not provided, one will be generated. We recommend
        /// using a globally unique identifier for this. We’ll enforce uniqueness within a rolling
        /// 24 hour period.
        /// </summary>
        [JsonProperty("identifier")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("identifier")]
#endif
        public string Identifier { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// The payload of the event. This must contain the fields corresponding to a meter’s
        /// <c>customer_mapping.event_payload_key</c> (default is <c>stripe_customer_id</c>) and
        /// <c>value_settings.event_payload_key</c> (default is <c>value</c>). Read more about the
        /// payload.
        /// </summary>
        [JsonProperty("payload")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payload")]
#endif
        public Dictionary<string, string> Payload { get; set; }

        /// <summary>
        /// The time of the event. Must be within the past 35 calendar days or up to 5 minutes in
        /// the future. Defaults to current timestamp if not specified.
        /// </summary>
        [JsonProperty("timestamp")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("timestamp")]
#endif
        public DateTime Timestamp { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
