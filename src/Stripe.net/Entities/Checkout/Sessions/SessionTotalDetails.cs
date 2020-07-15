namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionTotalDetails : StripeEntity<SessionTotalDetails>
    {
        /// <summary>
        /// This is the sum of all the line item discounts.
        /// </summary>
        [JsonProperty("amount_discount")]
        public long AmountDiscount { get; set; }

        /// <summary>
        /// This is the sum of all the line item tax amounts.
        /// </summary>
        [JsonProperty("amount_tax")]
        public long AmountTax { get; set; }

        /// <summary>
        /// Breakdown of individual tax and discount amounts that add up to the
        /// totals. This field is not included by default. To include it in
        /// the response, expand the breakdown field.
        /// </summary>
        [JsonProperty("breakdown")]
        public SessionTotalDetailsBreakdown Breakdown { get; set; }
    }
}
