// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class IntentActionApplySpendModifierRuleMaxBillingPeriodSpendCustomPricingUnitOverageRate : StripeEntity<IntentActionApplySpendModifierRuleMaxBillingPeriodSpendCustomPricingUnitOverageRate>, IHasId
    {
        /// <summary>
        /// ID of the custom pricing unit overage rate.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
