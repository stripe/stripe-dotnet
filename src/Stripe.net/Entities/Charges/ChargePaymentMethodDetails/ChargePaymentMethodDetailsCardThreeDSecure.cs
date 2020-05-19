namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ChargePaymentMethodDetailsCardThreeDSecure : StripeEntity<ChargePaymentMethodDetailsCardThreeDSecure>
    {
        [JsonProperty("authenticated")]
        public bool Authenticated { get; set; }

        [JsonProperty("succeeded")]
        public bool Succeeded { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }
}
