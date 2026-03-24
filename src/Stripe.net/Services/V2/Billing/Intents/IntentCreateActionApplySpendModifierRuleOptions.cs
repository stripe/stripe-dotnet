// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class IntentCreateActionApplySpendModifierRuleOptions : INestedOptions
    {
        /// <summary>
        /// What the spend modifier applies to.
        /// </summary>
        [JsonProperty("applies_to")]
        [STJS.JsonPropertyName("applies_to")]
        public string AppliesTo { get; set; }

        /// <summary>
        /// Type of the spend modifier.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Details for max billing period spend modifier. Only present if type is
        /// max_billing_period_spend.
        /// </summary>
        [JsonProperty("max_billing_period_spend")]
        [STJS.JsonPropertyName("max_billing_period_spend")]
        public IntentCreateActionApplySpendModifierRuleMaxBillingPeriodSpendOptions MaxBillingPeriodSpend { get; set; }
    }
}
