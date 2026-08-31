// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class BillingEvaluationPaymentDetailsShippingDetails : StripeEntity<BillingEvaluationPaymentDetailsShippingDetails>
    {
        /// <summary>
        /// Address data.
        /// </summary>
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public BillingEvaluationPaymentDetailsShippingDetailsAddress Address { get; set; }

        /// <summary>
        /// Shipping name.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Shipping phone number.
        /// </summary>
        [JsonProperty("phone")]
        [STJS.JsonPropertyName("phone")]
        public string Phone { get; set; }
    }
}
