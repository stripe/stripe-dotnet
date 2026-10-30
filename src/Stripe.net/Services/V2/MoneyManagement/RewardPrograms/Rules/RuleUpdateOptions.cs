// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement.RewardPrograms
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RuleUpdateOptions : BaseOptions
    {
        /// <summary>
        /// Conditions that must be true for this rule to match a card transaction.
        /// </summary>
        [JsonProperty("condition")]
        [STJS.JsonPropertyName("condition")]
        public RuleUpdateConditionOptions Condition { get; set; }

        /// <summary>
        /// Human-readable name for this rule. Max 250 characters.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The reward to grant when this rule matches.
        /// </summary>
        [JsonProperty("reward")]
        [STJS.JsonPropertyName("reward")]
        public RuleUpdateRewardOptions Reward { get; set; }
    }
}
