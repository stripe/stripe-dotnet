// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class BillingEvaluationPaymentDetailsPaymentMethodDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Billing information associated with the payment method used for the upcoming payment.
        /// </summary>
        [JsonProperty("billing_details")]
        [STJS.JsonPropertyName("billing_details")]
        public BillingEvaluationPaymentDetailsPaymentMethodDetailsBillingDetailsOptions BillingDetails { get; set; }

        /// <summary>
        /// ID of the payment method that the upcoming payment is charged to.
        /// </summary>
        [JsonProperty("payment_method")]
        [STJS.JsonPropertyName("payment_method")]
        public string PaymentMethod { get; set; }
    }
}
