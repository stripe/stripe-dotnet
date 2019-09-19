namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ChargePaymentMethodDetailsEps : StripeEntity<ChargePaymentMethodDetailsEps>
    {
        [JsonProperty("verified_name")]
        public string VerifiedName { get; set; }
    }
}
