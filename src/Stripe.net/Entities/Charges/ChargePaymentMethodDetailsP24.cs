namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsP24 : StripeEntity<ChargePaymentMethodDetailsP24>
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("verified_name")]
        public string VerifiedName { get; set; }
    }
}
