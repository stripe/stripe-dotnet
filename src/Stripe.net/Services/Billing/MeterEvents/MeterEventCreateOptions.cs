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

    public class MeterEventCreateOptions : BaseOptions
    {
        /// <summary>
        /// The name of the meter event. Corresponds with the <c>event_name</c> field on a meter.
        /// </summary>
        [JsonProperty("event_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("event_name")]
#endif
        public string EventName { get; set; }

        /// <summary>
        /// A unique identifier for the event. If not provided, one is generated. We recommend using
        /// UUID-like identifiers. We will enforce uniqueness within a rolling period of at least 24
        /// hours. The enforcement of uniqueness primarily addresses issues arising from accidental
        /// retries or other problems occurring within extremely brief time intervals. This approach
        /// helps prevent duplicate entries and ensures data integrity in high-frequency operations.
        /// </summary>
        [JsonProperty("identifier")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("identifier")]
#endif
        public string Identifier { get; set; }

        /// <summary>
        /// The payload of the event. This must contain the fields corresponding to a meter's
        /// <c>customer_mapping.event_payload_key</c> (default is <c>stripe_customer_id</c>) and
        /// <c>value_settings.event_payload_key</c> (default is <c>value</c>). Read more about the
        /// <a
        /// href="https://docs.stripe.com/billing/subscriptions/usage-based/recording-usage#payload-key-overrides">payload</a>.
        /// </summary>
        [JsonProperty("payload")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payload")]
#endif
        public Dictionary<string, string> Payload { get; set; }

        /// <summary>
        /// The time of the event. Measured in seconds since the Unix epoch. Must be within the past
        /// 35 calendar days or up to 5 minutes in the future. Defaults to current timestamp if not
        /// specified.
        /// </summary>
        [JsonProperty("timestamp")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("timestamp")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? Timestamp { get; set; }
    }
}
