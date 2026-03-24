// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class IntentActionApplySpendModifierRuleMaxBillingPeriodSpendAmountCustomPricingUnit : StripeEntity<IntentActionApplySpendModifierRuleMaxBillingPeriodSpendAmountCustomPricingUnit>
    {
        /// <summary>
        /// The value of the custom pricing unit.
        /// </summary>
        [JsonProperty("value")]
        [STJS.JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
