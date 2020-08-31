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

        [JsonProperty("breakdown")]
        public SessionTotalDetailsBreakdown Breakdown { get; set; }
    }
}
