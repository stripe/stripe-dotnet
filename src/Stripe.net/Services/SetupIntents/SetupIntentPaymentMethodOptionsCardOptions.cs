namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupIntentPaymentMethodOptionsCardOptions : INestedOptions
    {
        [JsonProperty("moto")]
        public bool? Moto { get; set; }

        [JsonProperty("request_three_d_secure")]
        public string RequestThreeDSecure { get; set; }
    }
}
