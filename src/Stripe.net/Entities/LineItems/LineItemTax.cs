namespace Stripe
{
    using Newtonsoft.Json;

    public class LineItemTax : StripeEntity<LineItemTax>
    {
        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("rate")]
        public TaxRate Rate { get; set; }
    }
}
