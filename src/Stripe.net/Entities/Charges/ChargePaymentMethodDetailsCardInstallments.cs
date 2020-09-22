// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsCardInstallments : StripeEntity<ChargePaymentMethodDetailsCardInstallments>
    {
        /// <summary>
        /// Installment plan selected for the payment.
        /// </summary>
        [JsonProperty("plan")]
        public PaymentIntentPaymentMethodOptionsCardInstallmentsPlan Plan { get; set; }
    }
}
