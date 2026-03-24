// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class IntentActionApplySpendModifierRuleMaxBillingPeriodSpend : StripeEntity<IntentActionApplySpendModifierRuleMaxBillingPeriodSpend>
    {
        /// <summary>
        /// The maximum amount allowed for the billing period.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public IntentActionApplySpendModifierRuleMaxBillingPeriodSpendAmount Amount { get; set; }

        /// <summary>
        /// The configuration for the overage rate for the custom pricing unit.
        /// </summary>
        [JsonProperty("custom_pricing_unit_overage_rate")]
        [STJS.JsonPropertyName("custom_pricing_unit_overage_rate")]
        public IntentActionApplySpendModifierRuleMaxBillingPeriodSpendCustomPricingUnitOverageRate CustomPricingUnitOverageRate { get; set; }
    }
}
