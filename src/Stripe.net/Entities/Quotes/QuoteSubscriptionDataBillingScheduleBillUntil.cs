// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QuoteSubscriptionDataBillingScheduleBillUntil : StripeEntity<QuoteSubscriptionDataBillingScheduleBillUntil>
    {
        /// <summary>
        /// The timestamp the billing schedule will apply until.
        /// </summary>
        [JsonProperty("computed_timestamp")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("computed_timestamp")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? ComputedTimestamp { get; set; }

        /// <summary>
        /// Specifies the billing period.
        /// </summary>
        [JsonProperty("duration")]
        [STJS.JsonPropertyName("duration")]
        public QuoteSubscriptionDataBillingScheduleBillUntilDuration Duration { get; set; }

        /// <summary>
        /// Lets you bill the period ending at a particular Quote line.
        /// </summary>
        [JsonProperty("line_ends_at")]
        [STJS.JsonPropertyName("line_ends_at")]
        public QuoteSubscriptionDataBillingScheduleBillUntilLineEndsAt LineEndsAt { get; set; }

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
        /// One of: <c>duration</c>, <c>line_ends_at</c>, <c>schedule_end</c>, <c>timestamp</c>, or
        /// <c>upcoming_invoice</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
