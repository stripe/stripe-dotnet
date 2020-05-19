namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsCardInstallments : StripeEntity<ChargePaymentMethodDetailsCardInstallments>
    {
        [JsonProperty("plan")]
        public PaymentIntentPaymentMethodOptionsCardInstallmentsPlan Plan { get; set; }
    }
}
