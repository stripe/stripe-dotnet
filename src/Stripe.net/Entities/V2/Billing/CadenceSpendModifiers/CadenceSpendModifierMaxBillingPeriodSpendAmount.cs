// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CadenceSpendModifierMaxBillingPeriodSpendAmount : StripeEntity<CadenceSpendModifierMaxBillingPeriodSpendAmount>
    {
        /// <summary>
        /// The custom pricing unit amount. Present if type is <c>custom_pricing_unit</c>.
        /// </summary>
        [JsonProperty("custom_pricing_unit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("custom_pricing_unit")]
#endif
        public CadenceSpendModifierMaxBillingPeriodSpendAmountCustomPricingUnit CustomPricingUnit { get; set; }

        /// <summary>
        /// The type of the spend modifier amount.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
