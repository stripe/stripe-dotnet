// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RewardProgramRuleCondition : StripeEntity<RewardProgramRuleCondition>
    {
        /// <summary>
        /// Card-spend specific matching condition.
        /// </summary>
        [JsonProperty("card_spend")]
        [STJS.JsonPropertyName("card_spend")]
        public RewardProgramRuleConditionCardSpend CardSpend { get; set; }
    }
}
