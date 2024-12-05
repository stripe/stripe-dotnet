// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class QuoteTotalDetails : StripeEntity<QuoteTotalDetails>
    {
        /// <summary>
        /// This is the sum of all the discounts.
        /// </summary>
        [JsonProperty("amount_discount")]
        public long AmountDiscount { get; set; }

        /// <summary>
        /// This is the sum of all the shipping amounts.
        /// </summary>
        [JsonProperty("amount_shipping")]
        public long? AmountShipping { get; set; }

        /// <summary>
        /// This is the sum of all the tax amounts.
        /// </summary>
        [JsonProperty("amount_tax")]
        public long AmountTax { get; set; }

        [JsonProperty("breakdown")]
        public QuoteTotalDetailsBreakdown Breakdown { get; set; }
    }
}
