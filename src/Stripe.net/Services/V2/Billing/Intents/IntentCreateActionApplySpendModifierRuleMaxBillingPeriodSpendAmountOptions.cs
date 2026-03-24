// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class IntentCreateActionApplySpendModifierRuleMaxBillingPeriodSpendAmountOptions : INestedOptions
    {
        /// <summary>
        /// The type of the amount.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The custom pricing unit amount.
        /// </summary>
        [JsonProperty("custom_pricing_unit")]
        [STJS.JsonPropertyName("custom_pricing_unit")]
        public IntentCreateActionApplySpendModifierRuleMaxBillingPeriodSpendAmountCustomPricingUnitOptions CustomPricingUnit { get; set; }
    }
}
