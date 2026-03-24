// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QuoteSubscriptionDataOverrideBillOnAcceptanceBillUntil : StripeEntity<QuoteSubscriptionDataOverrideBillOnAcceptanceBillUntil>
    {
        /// <summary>
        /// The materialized time.
        /// </summary>
        [JsonProperty("computed")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("computed")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? Computed { get; set; }

        /// <summary>
        /// Time span for the quote line starting from the <c>starts_at</c> date.
        /// </summary>
        [JsonProperty("duration")]
        [STJS.JsonPropertyName("duration")]
        public QuoteSubscriptionDataOverrideBillOnAcceptanceBillUntilDuration Duration { get; set; }

        /// <summary>
        /// The timestamp the given line ends at.
        /// </summary>
        [JsonProperty("line_ends_at")]
        [STJS.JsonPropertyName("line_ends_at")]
        public QuoteSubscriptionDataOverrideBillOnAcceptanceBillUntilLineEndsAt LineEndsAt { get; set; }

        /// <summary>
        /// A precise Unix timestamp.
        /// </summary>
        [JsonProperty("timestamp")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("timestamp")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// The type of method to specify the <c>bill_until</c> time.
        /// One of: <c>duration</c>, <c>line_ends_at</c>, <c>schedule_end</c>, <c>timestamp</c>, or
        /// <c>upcoming_invoice</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
