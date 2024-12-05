// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class QuoteLineItemDiscountDiscountEndOptions : INestedOptions
    {
        /// <summary>
        /// Time span for the redeemed discount.
        /// </summary>
        [JsonProperty("duration")]
        public QuoteLineItemDiscountDiscountEndDurationOptions Duration { get; set; }

        /// <summary>
        /// A precise Unix timestamp for the discount to end. Must be in the future.
        /// </summary>
        [JsonProperty("timestamp")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// The type of calculation made to determine when the discount ends.
        /// One of: <c>duration</c>, or <c>timestamp</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
