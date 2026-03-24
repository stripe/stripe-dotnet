// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentEvaluationPaymentDetailsPaymentMethodDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Billing information associated with the payment evaluation.
        /// </summary>
        [JsonProperty("billing_details")]
        [STJS.JsonPropertyName("billing_details")]
        public PaymentEvaluationPaymentDetailsPaymentMethodDetailsBillingDetailsOptions BillingDetails { get; set; }

        /// <summary>
        /// ID of the payment method used in this payment evaluation.
        /// </summary>
        [JsonProperty("payment_method")]
        [STJS.JsonPropertyName("payment_method")]
        public string PaymentMethod { get; set; }
    }
}
