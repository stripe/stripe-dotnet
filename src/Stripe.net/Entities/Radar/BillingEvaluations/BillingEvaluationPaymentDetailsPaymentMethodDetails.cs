// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class BillingEvaluationPaymentDetailsPaymentMethodDetails : StripeEntity<BillingEvaluationPaymentDetailsPaymentMethodDetails>
    {
        /// <summary>
        /// Billing information associated with the billing evaluation.
        /// </summary>
        [JsonProperty("billing_details")]
        [STJS.JsonPropertyName("billing_details")]
        public BillingEvaluationPaymentDetailsPaymentMethodDetailsBillingDetails BillingDetails { get; set; }

        /// <summary>
        /// The payment method that will be charged.
        /// </summary>
        [JsonProperty("payment_method")]
        [STJS.JsonPropertyName("payment_method")]
        public string PaymentMethod { get; set; }
    }
}
