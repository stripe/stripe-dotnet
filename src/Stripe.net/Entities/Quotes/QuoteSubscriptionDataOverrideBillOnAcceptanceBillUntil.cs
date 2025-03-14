// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class QuoteSubscriptionDataOverrideBillOnAcceptanceBillUntil : StripeEntity<QuoteSubscriptionDataOverrideBillOnAcceptanceBillUntil>
    {
        /// <summary>
        /// The materialized time.
        /// </summary>
        [JsonProperty("computed")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("computed")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? Computed { get; set; }

        /// <summary>
        /// Time span for the quote line starting from the <c>starts_at</c> date.
        /// </summary>
        [JsonProperty("duration")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("duration")]
#endif
        public QuoteSubscriptionDataOverrideBillOnAcceptanceBillUntilDuration Duration { get; set; }

        /// <summary>
        /// The timestamp the given line ends at.
        /// </summary>
        [JsonProperty("line_ends_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("line_ends_at")]
#endif
        public QuoteSubscriptionDataOverrideBillOnAcceptanceBillUntilLineEndsAt LineEndsAt { get; set; }

        /// <summary>
        /// A precise Unix timestamp.
        /// </summary>
        [JsonProperty("timestamp")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("timestamp")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// The type of method to specify the <c>bill_until</c> time.
        /// One of: <c>duration</c>, <c>line_ends_at</c>, <c>schedule_end</c>, <c>timestamp</c>, or
        /// <c>upcoming_invoice</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
