// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QuotePreviewSubscriptionScheduleBillingScheduleBillUntil : StripeEntity<QuotePreviewSubscriptionScheduleBillingScheduleBillUntil>
    {
        /// <summary>
        /// The timestamp the billing schedule will apply until.
        /// </summary>
        [JsonProperty("computed_timestamp")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("computed_timestamp")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime ComputedTimestamp { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Specifies the billing period.
        /// </summary>
        [JsonProperty("duration")]
        [STJS.JsonPropertyName("duration")]
        public QuotePreviewSubscriptionScheduleBillingScheduleBillUntilDuration Duration { get; set; }

        /// <summary>
        /// If specified, the billing schedule will apply until the specified timestamp.
        /// </summary>
        [JsonProperty("timestamp")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("timestamp")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Describes how the billing schedule will determine the end date. Either <c>duration</c>
        /// or <c>timestamp</c>.
        /// One of: <c>duration</c>, or <c>timestamp</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
