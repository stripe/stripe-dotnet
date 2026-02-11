// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class IntentActionApplySpendModifierRuleMaxBillingPeriodSpendAmount : StripeEntity<IntentActionApplySpendModifierRuleMaxBillingPeriodSpendAmount>
    {
        /// <summary>
        /// The type of the amount.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// The custom pricing unit amount.
        /// </summary>
        [JsonProperty("custom_pricing_unit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("custom_pricing_unit")]
#endif
        public IntentActionApplySpendModifierRuleMaxBillingPeriodSpendAmountCustomPricingUnit CustomPricingUnit { get; set; }
    }
}
