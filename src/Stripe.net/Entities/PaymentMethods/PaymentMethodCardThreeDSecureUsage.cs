namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodCardThreeDSecureUsage : StripeEntity
    {
        [JsonProperty("supported")]
        public bool? Supported { get; set; }
    }
}
