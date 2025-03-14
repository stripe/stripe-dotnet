// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentRecordPaymentMethodDetails : StripeEntity<PaymentRecordPaymentMethodDetails>
    {
        /// <summary>
        /// The billing details associated with the method of payment.
        /// </summary>
        [JsonProperty("billing_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_details")]
#endif
        public PaymentRecordPaymentMethodDetailsBillingDetails BillingDetails { get; set; }

        /// <summary>
        /// Information about the custom (user-defined) payment method used to make this payment.
        /// </summary>
        [JsonProperty("custom")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("custom")]
#endif
        public PaymentRecordPaymentMethodDetailsCustom Custom { get; set; }

        /// <summary>
        /// ID of the Stripe PaymentMethod used to make this payment.
        /// </summary>
        [JsonProperty("payment_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method")]
#endif
        public string PaymentMethod { get; set; }

        /// <summary>
        /// The type of Payment Method used for this payment attempt.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
