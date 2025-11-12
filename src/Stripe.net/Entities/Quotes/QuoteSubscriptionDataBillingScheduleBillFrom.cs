// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class QuoteSubscriptionDataBillingScheduleBillFrom : StripeEntity<QuoteSubscriptionDataBillingScheduleBillFrom>
    {
        /// <summary>
        /// Use an index to specify the position of an amendment to start prebilling with.
        /// </summary>
        [JsonProperty("amendment_start")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amendment_start")]
#endif
        public QuoteSubscriptionDataBillingScheduleBillFromAmendmentStart AmendmentStart { get; set; }

        /// <summary>
        /// The time the billing schedule applies from.
        /// </summary>
        [JsonProperty("computed_timestamp")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("computed_timestamp")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? ComputedTimestamp { get; set; }

        /// <summary>
        /// Lets you bill the period starting from a particular Quote line.
        /// </summary>
        [JsonProperty("line_starts_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("line_starts_at")]
#endif
        public QuoteSubscriptionDataBillingScheduleBillFromLineStartsAt LineStartsAt { get; set; }

        /// <summary>
        /// Timestamp is calculated from the request time.
        /// </summary>
        [JsonProperty("relative")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("relative")]
#endif
        public QuoteSubscriptionDataBillingScheduleBillFromRelative Relative { get; set; }

        /// <summary>
        /// Use a precise Unix timestamp for prebilling to start. Must be earlier than
        /// <c>bill_until</c>.
        /// </summary>
        [JsonProperty("timestamp")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("timestamp")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Describes how the billing schedule determines the start date. Possible values are
        /// <c>timestamp</c>, <c>relative</c>, <c>amendment_start</c>, <c>now</c>,
        /// <c>quote_acceptance_date</c>, <c>line_starts_at</c>, or <c>pause_collection_start</c>.
        /// One of: <c>amendment_start</c>, <c>line_starts_at</c>, <c>now</c>,
        /// <c>pause_collection_start</c>, <c>quote_acceptance_date</c>, <c>relative</c>, or
        /// <c>timestamp</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
