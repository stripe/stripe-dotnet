// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ServiceActionCreditGrantAmount : StripeEntity<ServiceActionCreditGrantAmount>
    {
        /// <summary>
        /// The custom pricing unit amount of the credit grant. Required if <c>type</c> is
        /// <c>custom_pricing_unit</c>.
        /// </summary>
        [JsonProperty("custom_pricing_unit")]
        [STJS.JsonPropertyName("custom_pricing_unit")]
        public ServiceActionCreditGrantAmountCustomPricingUnit CustomPricingUnit { get; set; }

        /// <summary>
        /// The monetary amount of the credit grant. Required if <c>type</c> is <c>monetary</c>.
        /// </summary>
        [JsonProperty("monetary")]
        [STJS.JsonPropertyName("monetary")]
        public V2.Amount Monetary { get; set; }

        /// <summary>
        /// The type of the credit grant amount. We currently support <c>monetary</c> and
        /// <c>custom_pricing_unit</c> billing credits.
        /// One of: <c>custom_pricing_unit</c>, or <c>monetary</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
