// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentAttemptRecordPaymentMethodDetailsCardInstallments : StripeEntity<PaymentAttemptRecordPaymentMethodDetailsCardInstallments>
    {
        [JsonProperty("plan")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("plan")]
#endif
        public PaymentAttemptRecordPaymentMethodDetailsCardInstallmentsPlan Plan { get; set; }
    }
}
