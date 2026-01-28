// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentEvaluationPaymentDetailsPaymentMethodDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Billing information associated with the payment evaluation.
        /// </summary>
        [JsonProperty("billing_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_details")]
#endif
        public PaymentEvaluationPaymentDetailsPaymentMethodDetailsBillingDetailsOptions BillingDetails { get; set; }

        /// <summary>
        /// ID of the payment method used in this payment evaluation.
        /// </summary>
        [JsonProperty("payment_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method")]
#endif
        public string PaymentMethod { get; set; }
    }
}
