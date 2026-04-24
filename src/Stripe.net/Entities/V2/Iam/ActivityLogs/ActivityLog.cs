// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// An activity log records a single action performed on an account.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ActivityLog : StripeEntity<ActivityLog>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier of the activity log entry.
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
        /// The actor that performed the action.
        /// </summary>
        [JsonProperty("actor")]
        [STJS.JsonPropertyName("actor")]
        public ActivityLogActor Actor { get; set; }

        /// <summary>
        /// The account on which the action was performed.
        /// </summary>
        [JsonProperty("context")]
        [STJS.JsonPropertyName("context")]
        public string Context { get; set; }

        /// <summary>
        /// Timestamp when the activity log entry was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Action-specific details of the activity log entry.
        /// </summary>
        [JsonProperty("details")]
        [STJS.JsonPropertyName("details")]
        public ActivityLogDetails Details { get; set; }

        /// <summary>
        /// Whether the action was performed in live mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The type of action that was performed.
        /// One of: <c>api_key_created</c>, <c>api_key_deleted</c>, <c>api_key_updated</c>,
        /// <c>api_key_viewed</c>, <c>user_invite_accepted</c>, <c>user_invite_created</c>,
        /// <c>user_invite_deleted</c>, <c>user_roles_deleted</c>, or <c>user_roles_updated</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
