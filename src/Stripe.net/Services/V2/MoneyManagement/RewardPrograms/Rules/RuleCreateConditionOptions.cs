// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement.RewardPrograms
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RuleCreateConditionOptions : INestedOptions
    {
        /// <summary>
        /// Card-spend specific matching condition.
        /// </summary>
        [JsonProperty("card_spend")]
        [STJS.JsonPropertyName("card_spend")]
        public RuleCreateConditionCardSpendOptions CardSpend { get; set; }
    }
}
