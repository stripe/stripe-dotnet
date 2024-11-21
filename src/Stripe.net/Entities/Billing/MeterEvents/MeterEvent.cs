// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// A billing meter event represents a customer's usage of a product. Meter events are used
    /// to bill a customer based on their usage. Meter events are associated with billing
    /// meters, which define the shape of the event's payload and how those events are
    /// aggregated for billing.
    /// </summary>
    public class MeterEvent : StripeEntity<MeterEvent>, IHasObject
    {
        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif

        public string Object { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
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
        /// A unique identifier for the event.
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
        /// The payload of the event. This contains the fields corresponding to a meter's
        /// <c>customer_mapping.event_payload_key</c> (default is <c>stripe_customer_id</c>) and
        /// <c>value_settings.event_payload_key</c> (default is <c>value</c>). Read more about the
        /// <a
        /// href="https://stripe.com/docs/billing/subscriptions/usage-based/recording-usage#payload-key-overrides">payload</a>.
        /// </summary>
        [JsonProperty("payload")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payload")]
#endif

        public Dictionary<string, string> Payload { get; set; }

        /// <summary>
        /// The timestamp passed in when creating the event. Measured in seconds since the Unix
        /// epoch.
        /// </summary>
        [JsonProperty("timestamp")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("timestamp")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime Timestamp { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
