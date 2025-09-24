// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ServiceActionCreditGrantAmountCustomPricingUnit : StripeEntity<ServiceActionCreditGrantAmountCustomPricingUnit>, IHasId
    {
        /// <summary>
        /// The Custom Pricing Unit object.
        /// </summary>
        [JsonProperty("custom_pricing_unit_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("custom_pricing_unit_details")]
#endif
        public CustomPricingUnit CustomPricingUnitDetails { get; set; }

        /// <summary>
        /// The id of the custom pricing unit.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// The value of the credit grant, decimal value represented as a string.
        /// </summary>
        [JsonProperty("value")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("value")]
#endif
        public string Value { get; set; }
    }
}
