// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class IntentActionApplySpendModifierRuleMaxBillingPeriodSpendAmountCustomPricingUnit : StripeEntity<IntentActionApplySpendModifierRuleMaxBillingPeriodSpendAmountCustomPricingUnit>, IHasId
    {
        /// <summary>
        /// The id of the custom pricing unit.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The value of the custom pricing unit.
        /// </summary>
        [JsonProperty("value")]
        [STJS.JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
