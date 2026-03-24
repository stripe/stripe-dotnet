// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class IntentCreateActionApplySpendModifierRuleMaxBillingPeriodSpendOptions : INestedOptions
    {
        /// <summary>
        /// The maximum amount allowed for the billing period.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public IntentCreateActionApplySpendModifierRuleMaxBillingPeriodSpendAmountOptions Amount { get; set; }

        /// <summary>
        /// The configuration for the overage rate for the custom pricing unit.
        /// </summary>
        [JsonProperty("custom_pricing_unit_overage_rate")]
        [STJS.JsonPropertyName("custom_pricing_unit_overage_rate")]
        public IntentCreateActionApplySpendModifierRuleMaxBillingPeriodSpendCustomPricingUnitOverageRateOptions CustomPricingUnitOverageRate { get; set; }
    }
}
