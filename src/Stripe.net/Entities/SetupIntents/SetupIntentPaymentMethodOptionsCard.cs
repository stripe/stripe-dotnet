namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupIntentPaymentMethodOptionsCard : StripeEntity<SetupIntentPaymentMethodOptionsCard>
    {
        [JsonProperty("request_three_d_secure")]
        public string RequestThreeDSecure { get; set; }
    }
}
