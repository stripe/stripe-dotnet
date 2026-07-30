// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CardProductGraduationState : StripeEntity<CardProductGraduationState>
    {
        /// <summary>
        /// Status of the product graduation request. <c>pending</c> while awaiting card network
        /// confirmation, <c>succeeded</c> once confirmed, <c>failed</c> if rejected.
        /// One of: <c>failed</c>, <c>pending</c>, or <c>succeeded</c>.
        /// </summary>
        [JsonProperty("state")]
        [STJS.JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// The product code the card graduation is targeting.
        /// </summary>
        [JsonProperty("target_product_code")]
        [STJS.JsonPropertyName("target_product_code")]
        public string TargetProductCode { get; set; }
    }
}
