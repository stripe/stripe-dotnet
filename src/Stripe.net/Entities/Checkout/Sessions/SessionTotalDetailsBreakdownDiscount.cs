namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionTotalDetailsBreakdownDiscount : StripeEntity<SessionTotalDetailsBreakdownDiscount>
    {
        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("discount")]
        public Discount Discount { get; set; }
    }
}
