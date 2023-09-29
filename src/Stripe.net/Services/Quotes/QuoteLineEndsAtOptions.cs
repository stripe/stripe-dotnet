// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class QuoteLineEndsAtOptions : INestedOptions
    {
        /// <summary>
        /// Use the <c>end</c> time of a given discount.
        /// </summary>
        [JsonProperty("discount_end")]
        public QuoteLineEndsAtDiscountEndOptions DiscountEnd { get; set; }

        /// <summary>
        /// Time span for the quote line starting from the <c>starts_at</c> date.
        /// </summary>
        [JsonProperty("duration")]
        public QuoteLineEndsAtDurationOptions Duration { get; set; }

        /// <summary>
        /// A precise Unix timestamp.
        /// </summary>
        [JsonProperty("timestamp")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Select a way to pass in <c>ends_at</c>.
        /// One of: <c>discount_end</c>, <c>duration</c>, <c>quote_acceptance_date</c>,
        /// <c>schedule_end</c>, <c>timestamp</c>, or <c>upcoming_invoice</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
