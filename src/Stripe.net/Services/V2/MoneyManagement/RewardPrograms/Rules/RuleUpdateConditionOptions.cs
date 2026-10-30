// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement.RewardPrograms
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RuleUpdateConditionOptions : INestedOptions
    {
        /// <summary>
        /// Card-spend specific matching condition.
        /// </summary>
        [JsonProperty("card_spend")]
        [STJS.JsonPropertyName("card_spend")]
        public RuleUpdateConditionCardSpendOptions CardSpend { get; set; }
    }
}
