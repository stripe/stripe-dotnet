// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class QuoteComputedRecurringTotalDetails : StripeEntity<QuoteComputedRecurringTotalDetails>
    {
        /// <summary>
        /// This is the sum of all the line item discounts.
        /// </summary>
        [JsonProperty("amount_discount")]
        public long AmountDiscount { get; set; }

        /// <summary>
        /// This is the sum of all the line item shipping amounts.
        /// </summary>
        [JsonProperty("amount_shipping")]
        public long? AmountShipping { get; set; }

        /// <summary>
        /// This is the sum of all the line item tax amounts.
        /// </summary>
        [JsonProperty("amount_tax")]
        public long AmountTax { get; set; }

        [JsonProperty("breakdown")]
        public QuoteComputedRecurringTotalDetailsBreakdown Breakdown { get; set; }
    }
}
