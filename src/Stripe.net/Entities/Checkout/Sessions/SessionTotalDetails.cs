namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionTotalDetails : StripeEntity<SessionTotalDetails>
    {
        [JsonProperty("amount_discount")]
        public long AmountDiscount { get; set; }

        [JsonProperty("amount_tax")]
        public long AmountTax { get; set; }

        [JsonProperty("breakdown")]
        public SessionTotalDetailsBreakdown Breakdown { get; set; }
    }
}
