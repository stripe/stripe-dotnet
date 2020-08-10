namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsCardInstallmentsPlan : StripeEntity<PaymentIntentPaymentMethodOptionsCardInstallmentsPlan>
    {
        [JsonProperty("count")]
        public long? Count { get; set; }

        [JsonProperty("interval")]
        public string Interval { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
