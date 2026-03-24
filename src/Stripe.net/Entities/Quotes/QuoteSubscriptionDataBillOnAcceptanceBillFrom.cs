// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QuoteSubscriptionDataBillOnAcceptanceBillFrom : StripeEntity<QuoteSubscriptionDataBillOnAcceptanceBillFrom>
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
        /// The timestamp the given line starts at.
        /// </summary>
        [JsonProperty("line_starts_at")]
        [STJS.JsonPropertyName("line_starts_at")]
        public QuoteSubscriptionDataBillOnAcceptanceBillFromLineStartsAt LineStartsAt { get; set; }

        /// <summary>
        /// A precise Unix timestamp.
        /// </summary>
        [JsonProperty("timestamp")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("timestamp")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// The type of method to specify the <c>bill_from</c> time.
        /// One of: <c>line_starts_at</c>, <c>now</c>, <c>pause_collection_start</c>,
        /// <c>quote_acceptance_date</c>, or <c>timestamp</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
