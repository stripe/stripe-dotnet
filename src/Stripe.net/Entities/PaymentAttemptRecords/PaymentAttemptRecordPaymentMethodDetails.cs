// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentAttemptRecordPaymentMethodDetails : StripeEntity<PaymentAttemptRecordPaymentMethodDetails>
    {
        /// <summary>
        /// The billing details associated with the method of payment.
        /// </summary>
        [JsonProperty("billing_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_details")]
#endif
        public PaymentAttemptRecordPaymentMethodDetailsBillingDetails BillingDetails { get; set; }

        /// <summary>
        /// Details of the card used for this payment attempt.
        /// </summary>
        [JsonProperty("card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card")]
#endif
        public PaymentAttemptRecordPaymentMethodDetailsCard Card { get; set; }

        /// <summary>
        /// Custom Payment Methods represent Payment Method types not modeled directly in the Stripe
        /// API. This resource consists of details about the custom payment method used for this
        /// payment attempt.
        /// </summary>
        [JsonProperty("custom")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("custom")]
#endif
        public PaymentAttemptRecordPaymentMethodDetailsCustom Custom { get; set; }

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
        /// One of: <c>card</c>, or <c>custom</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
