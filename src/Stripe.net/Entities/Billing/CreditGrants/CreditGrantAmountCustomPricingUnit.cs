// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CreditGrantAmountCustomPricingUnit : StripeEntity<CreditGrantAmountCustomPricingUnit>, IHasId
    {
        /// <summary>
        /// The custom pricing unit object.
        /// </summary>
        [JsonProperty("custom_pricing_unit_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("custom_pricing_unit_details")]
#endif
        public CreditGrantAmountCustomPricingUnitCustomPricingUnitDetails CustomPricingUnitDetails { get; set; }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// A positive integer representing the amount.
        /// </summary>
        [JsonProperty("value")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("value")]
#endif
        public decimal Value { get; set; }
    }
}
