// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A RewardProgramEnrollment represents the binding of a connected account / Issuer Program
    /// to a shared RewardProgram. RewardProgramEnrollments are platform-owned canonical objects
    /// and are active by default on creation. At most one RewardProgramEnrollment may be active
    /// per Issuer Program globally, across all RewardPrograms.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RewardProgramEnrollment : StripeEntity<RewardProgramEnrollment>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the RewardProgramEnrollment.
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
        /// The connected account enrolled in this RewardProgram. Immutable after creation.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// Issuing-specific per-enrollment configuration. Immutable after creation.
        /// </summary>
        [JsonProperty("card_spend")]
        [STJS.JsonPropertyName("card_spend")]
        public RewardProgramEnrollmentCardSpend CardSpend { get; set; }

        /// <summary>
        /// Time at which the RewardProgramEnrollment was created.
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
        /// The ID of the RewardProgram this enrollment belongs to. Immutable after creation.
        /// </summary>
        [JsonProperty("reward_program")]
        [STJS.JsonPropertyName("reward_program")]
        public string RewardProgram { get; set; }

        /// <summary>
        /// The status of the RewardProgramEnrollment. Active by default on creation; use
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
