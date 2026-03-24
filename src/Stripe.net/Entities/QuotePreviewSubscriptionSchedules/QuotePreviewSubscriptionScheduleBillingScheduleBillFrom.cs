// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QuotePreviewSubscriptionScheduleBillingScheduleBillFrom : StripeEntity<QuotePreviewSubscriptionScheduleBillingScheduleBillFrom>
    {
        /// <summary>
        /// The time the billing schedule applies from.
        /// </summary>
        [JsonProperty("computed_timestamp")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("computed_timestamp")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime ComputedTimestamp { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Use a precise Unix timestamp for prebilling to start. Must be earlier than
        /// <c>bill_until</c>.
        /// </summary>
        [JsonProperty("timestamp")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("timestamp")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Describes how the billing schedule determines the start date. Possible values are
        /// <c>timestamp</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
