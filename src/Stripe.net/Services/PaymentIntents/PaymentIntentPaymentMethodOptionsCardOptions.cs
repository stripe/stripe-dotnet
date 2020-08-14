namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsCardOptions : INestedOptions
    {
        [JsonProperty("installments")]
        public PaymentIntentPaymentMethodOptionsCardInstallmentsOptions Installments { get; set; }

        [JsonProperty("moto")]
        public bool? Moto { get; set; }

        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("request_three_d_secure")]
        public string RequestThreeDSecure { get; set; }
    }
}
