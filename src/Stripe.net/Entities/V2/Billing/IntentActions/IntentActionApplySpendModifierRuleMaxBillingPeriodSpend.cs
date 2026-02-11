// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class IntentActionApplySpendModifierRuleMaxBillingPeriodSpend : StripeEntity<IntentActionApplySpendModifierRuleMaxBillingPeriodSpend>
    {
        /// <summary>
        /// The maximum amount allowed for the billing period.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public IntentActionApplySpendModifierRuleMaxBillingPeriodSpendAmount Amount { get; set; }

        /// <summary>
        /// The configration for the overage rate for the custom pricing unit.
        /// </summary>
        [JsonProperty("custom_pricing_unit_overage_rate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("custom_pricing_unit_overage_rate")]
#endif
        public IntentActionApplySpendModifierRuleMaxBillingPeriodSpendCustomPricingUnitOverageRate CustomPricingUnitOverageRate { get; set; }
    }
}
