// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class IntentActionApplySpendModifierRule : StripeEntity<IntentActionApplySpendModifierRule>, IHasId
    {
        /// <summary>
        /// What the spend modifier applies to.
        /// </summary>
        [JsonProperty("applies_to")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("applies_to")]
#endif
        public string AppliesTo { get; set; }

        /// <summary>
        /// The ID of the spend modifier.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// Type of the spend modifier.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// Details for max billing period spend modifier. Only present if type is
        /// max_billing_period_spend.
        /// </summary>
        [JsonProperty("max_billing_period_spend")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("max_billing_period_spend")]
#endif
        public IntentActionApplySpendModifierRuleMaxBillingPeriodSpend MaxBillingPeriodSpend { get; set; }
    }
}
