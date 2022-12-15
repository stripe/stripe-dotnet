// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class QuoteSubscriptionDataBillOnAcceptanceBillFrom : StripeEntity<QuoteSubscriptionDataBillOnAcceptanceBillFrom>
    {
        /// <summary>
        /// The materialized time.
        /// </summary>
        [JsonProperty("computed")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Computed { get; set; }

        /// <summary>
        /// The timestamp the given line starts at.
        /// </summary>
        [JsonProperty("line_starts_at")]
        public QuoteSubscriptionDataBillOnAcceptanceBillFromLineStartsAt LineStartsAt { get; set; }

        /// <summary>
        /// A precise Unix timestamp.
        /// </summary>
        [JsonProperty("timestamp")]
        public long? Timestamp { get; set; }

        /// <summary>
        /// The type of method to specify the <c>bill_from</c> time.
        /// One of: <c>line_starts_at</c>, <c>now</c>, <c>quote_acceptance_date</c>, or
        /// <c>timestamp</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
