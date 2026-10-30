// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A RewardProgram represents shared card-spend cashback reward configuration for Issuing
    /// Card-Spend Rewards. It is not scoped to a single Issuer Program or connected account.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RewardProgram : StripeEntity<RewardProgram>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the RewardProgram.
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
        /// Time at which the RewardProgram was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Determines who performs reward money movement after rule evaluation. Immutable after
        /// creation.
        /// One of: <c>application</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("fulfilled_by")]
        [STJS.JsonPropertyName("fulfilled_by")]
        public string FulfilledBy { get; set; }

        /// <summary>
        /// Whether this object exists in livemode or testmode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Display name for the RewardProgram.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The status of the RewardProgram. Inactive by default on creation; use
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
