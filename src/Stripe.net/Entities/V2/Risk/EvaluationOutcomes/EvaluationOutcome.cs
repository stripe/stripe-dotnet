// File generated from our OpenAPI spec
namespace Stripe.V2.Risk
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// An immutable, point-in-time risk evaluation result that captures recommended controls
    /// and their expected impact. The type identifies the scenario evaluated and its
    /// corresponding details. Unavailable optional values are null.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class EvaluationOutcome : StripeEntity<EvaluationOutcome>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the evaluation outcome, prefixed with evalout_.
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
        /// Subject of the evaluation. Exactly one of account, customer, or data is provided.
        /// </summary>
        [JsonProperty("account_details")]
        [STJS.JsonPropertyName("account_details")]
        public EvaluationOutcomeAccountDetails AccountDetails { get; set; }

        /// <summary>
        /// Timestamp when the evaluation was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Recommended controls, expected financial impact, and supporting signals for a
        /// delinquency evaluation. Populated when type is delinquency; null otherwise.
        /// </summary>
        [JsonProperty("delinquency")]
        [STJS.JsonPropertyName("delinquency")]
        public EvaluationOutcomeDelinquency Delinquency { get; set; }

        /// <summary>
        /// Whether the evaluation outcome is in live mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// How the outcome was generated.
        /// One of: <c>rule_outcome</c>, or <c>stripe_recommendation</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("origin")]
        [STJS.JsonPropertyName("origin")]
        public string Origin { get; set; }

        /// <summary>
        /// Scenario evaluated; determines which type-specific payload is provided.
        /// One of: <c>delinquency</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
