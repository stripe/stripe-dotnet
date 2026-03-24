// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentEvaluationPaymentDetailsPaymentMethodDetailsBillingDetails : StripeEntity<PaymentEvaluationPaymentDetailsPaymentMethodDetailsBillingDetails>
    {
        /// <summary>
        /// Address data.
        /// </summary>
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public PaymentEvaluationPaymentDetailsPaymentMethodDetailsBillingDetailsAddress Address { get; set; }

        /// <summary>
        /// Email address.
        /// </summary>
        [JsonProperty("email")]
        [STJS.JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// Full name.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Billing phone number (including extension).
        /// </summary>
        [JsonProperty("phone")]
        [STJS.JsonPropertyName("phone")]
        public string Phone { get; set; }
    }
}
