// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentAttemptRecordProcessorDetailsCustom : StripeEntity<PaymentAttemptRecordProcessorDetailsCustom>
    {
        /// <summary>
        /// An opaque string for manual reconciliation of this payment, for example a check number
        /// or a payment processor ID.
        /// </summary>
        [JsonProperty("payment_reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_reference")]
#endif
        public string PaymentReference { get; set; }
    }
}
