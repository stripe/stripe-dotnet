namespace Stripe
{
    using Newtonsoft.Json;

    public class LineItemDiscount : StripeEntity<LineItemDiscount>
    {
        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("discount")]
        public Discount Discount { get; set; }
    }
}
