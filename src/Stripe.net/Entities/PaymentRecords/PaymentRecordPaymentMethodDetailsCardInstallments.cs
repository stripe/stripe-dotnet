// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentRecordPaymentMethodDetailsCardInstallments : StripeEntity<PaymentRecordPaymentMethodDetailsCardInstallments>
    {
        /// <summary>
        /// Installment plan selected for the payment.
        /// </summary>
        [JsonProperty("plan")]
        [STJS.JsonPropertyName("plan")]
        public PaymentRecordPaymentMethodDetailsCardInstallmentsPlan Plan { get; set; }
    }
}
