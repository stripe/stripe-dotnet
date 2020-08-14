namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionTotalDetailsBreakdownTax : StripeEntity<SessionTotalDetailsBreakdownTax>
    {
        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("rate")]
        public TaxRate Rate { get; set; }
    }
}
