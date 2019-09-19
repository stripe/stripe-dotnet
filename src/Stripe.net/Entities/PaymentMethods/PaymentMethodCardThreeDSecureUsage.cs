namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodCardThreeDSecureUsage : StripeEntity<PaymentMethodCardThreeDSecureUsage>
    {
        [JsonProperty("supported")]
        public bool? Supported { get; set; }
    }
}
