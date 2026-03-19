// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RateCardRateCustomPricingUnitAmount : StripeEntity<RateCardRateCustomPricingUnitAmount>, IHasId
    {
        /// <summary>
        /// The Custom Pricing Unit object.
        /// </summary>
        [JsonProperty("custom_pricing_unit_details")]
        [STJS.JsonPropertyName("custom_pricing_unit_details")]
        public CustomPricingUnit CustomPricingUnitDetails { get; set; }

        /// <summary>
        /// The id of the custom pricing unit.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The unit value for the custom pricing unit, as a string.
        /// </summary>
        [JsonProperty("value")]
        [STJS.JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
