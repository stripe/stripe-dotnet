namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsCardInstallmentsOptions : INestedOptions
    {
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        [JsonProperty("plan")]
        public PaymentIntentPaymentMethodOptionsCardInstallmentsPlanOptions Plan { get; set; }
    }
}
