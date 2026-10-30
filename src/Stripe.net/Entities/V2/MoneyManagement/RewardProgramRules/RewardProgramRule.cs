// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A RewardProgramRule defines the matching conditions and cashback reward outcome shared
    /// across all active enrollments in a RewardProgram. At most one RewardProgramRule may be
    /// active per RewardProgram at a time.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RewardProgramRule : StripeEntity<RewardProgramRule>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the RewardProgramRule.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Conditions that must be true for this rule to match a card transaction. Empty means the
        /// rule matches all transactions.
        /// </summary>
        [JsonProperty("condition")]
        [STJS.JsonPropertyName("condition")]
        public RewardProgramRuleCondition Condition { get; set; }

        /// <summary>
        /// Time at which the RewardProgramRule was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Whether this object exists in livemode or testmode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

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
        public RewardProgramRuleReward Reward { get; set; }

        /// <summary>
        /// The ID of the RewardProgram this rule belongs to. Immutable after creation.
        /// </summary>
        [JsonProperty("reward_program")]
        [STJS.JsonPropertyName("reward_program")]
        public string RewardProgram { get; set; }

        /// <summary>
        /// The status of the RewardProgramRule. Inactive by default on creation; use
        /// activate/deactivate to change.
        /// One of: <c>active</c>, or <c>inactive</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
