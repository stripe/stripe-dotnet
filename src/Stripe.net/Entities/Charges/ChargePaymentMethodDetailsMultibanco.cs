namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsMultibanco : StripeEntity<ChargePaymentMethodDetailsMultibanco>
    {
        [JsonProperty("entity")]
        public string Entity { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }
    }
}
