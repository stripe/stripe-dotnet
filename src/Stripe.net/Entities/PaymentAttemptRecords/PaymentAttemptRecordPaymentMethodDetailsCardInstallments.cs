// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentAttemptRecordPaymentMethodDetailsCardInstallments : StripeEntity<PaymentAttemptRecordPaymentMethodDetailsCardInstallments>
    {
        /// <summary>
        /// Installment plan selected for the payment.
        /// </summary>
        [JsonProperty("plan")]
        [STJS.JsonPropertyName("plan")]
        public PaymentAttemptRecordPaymentMethodDetailsCardInstallmentsPlan Plan { get; set; }
    }
}
