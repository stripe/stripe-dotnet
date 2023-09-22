// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class QuoteLineStartsAtOptions : INestedOptions
    {
        /// <summary>
        /// Use the <c>end</c> time of a given discount.
        /// </summary>
        [JsonProperty("discount_end")]
        public QuoteLineStartsAtDiscountEndOptions DiscountEnd { get; set; }

        /// <summary>
        /// The timestamp the given line ends at.
        /// </summary>
        [JsonProperty("line_ends_at")]
        public QuoteLineStartsAtLineEndsAtOptions LineEndsAt { get; set; }

        /// <summary>
        /// A precise Unix timestamp.
        /// </summary>
        [JsonProperty("timestamp")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Select a way to pass in <c>starts_at</c>.
        /// One of: <c>discount_end</c>, <c>line_ends_at</c>, <c>now</c>,
        /// <c>quote_acceptance_date</c>, <c>schedule_end</c>, <c>timestamp</c>, or
        /// <c>upcoming_invoice</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
