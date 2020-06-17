namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsEps : StripeEntity<ChargePaymentMethodDetailsEps>
    {
        [JsonProperty("verified_name")]
        public string VerifiedName { get; set; }
    }
}
