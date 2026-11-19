// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ActivityLogDetailsRadarOldRule : StripeEntity<ActivityLogDetailsRadarOldRule>, IHasId
    {
        /// <summary>
        /// Action performed when the rule matches.
        /// One of: <c>allow</c>, <c>block</c>, <c>block_fa_outbound</c>, <c>manual_review</c>,
        /// <c>payout_pause</c>, <c>raise_review</c>, <c>request_credentials</c>, or
        /// <c>resolve_dispute</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("action")]
        [STJS.JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// Whether the rule is enabled.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Identifier of the rule.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Objective of the rule.
        /// </summary>
        [JsonProperty("objective")]
        [STJS.JsonPropertyName("objective")]
        public string Objective { get; set; }

        /// <summary>
        /// Rule expression evaluated to determine whether the rule matches.
        /// </summary>
        [JsonProperty("predicate")]
        [STJS.JsonPropertyName("predicate")]
        public string Predicate { get; set; }

        /// <summary>
        /// Percentage of matching traffic to which the rule applies, between 0 and 100, serialized
        /// as a decimal string.
        /// </summary>
        [JsonProperty("rollout_percentage")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("rollout_percentage")]
        public decimal? RolloutPercentage { get; set; }

        /// <summary>
        /// Type of entity evaluated by the rule.
        /// One of: <c>account</c>, or <c>payment</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
