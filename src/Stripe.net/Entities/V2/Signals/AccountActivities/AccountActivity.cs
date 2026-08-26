// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Account Activity resource for the Signals API.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountActivity : StripeEntity<AccountActivity>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the account activity.
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
        /// The account, customer, or inline account data associated with the activity.
        /// </summary>
        [JsonProperty("account_details")]
        [STJS.JsonPropertyName("account_details")]
        public AccountActivityAccountDetails AccountDetails { get; set; }

        /// <summary>
        /// The account evaluation this activity is associated with, when applicable.
        /// </summary>
        [JsonProperty("account_evaluation")]
        [STJS.JsonPropertyName("account_evaluation")]
        public string AccountEvaluation { get; set; }

        /// <summary>
        /// Timestamp at which the account activity was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Details for the login attempt. Present only when type is login_attempt.
        /// </summary>
        [JsonProperty("login_attempt")]
        [STJS.JsonPropertyName("login_attempt")]
        public AccountActivityLoginAttempt LoginAttempt { get; set; }

        /// <summary>
        /// Details for the login decision. Present only when type is login_decision.
        /// </summary>
        [JsonProperty("login_decision")]
        [STJS.JsonPropertyName("login_decision")]
        public AccountActivityLoginDecision LoginDecision { get; set; }

        /// <summary>
        /// Timestamp at which the activity occurred. Defaults to the created time if not provided.
        /// </summary>
        [JsonProperty("occurred_at")]
        [STJS.JsonPropertyName("occurred_at")]
        public DateTime OccurredAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Details for the registration attempt. Present only when type is registration_attempt.
        /// </summary>
        [JsonProperty("registration_attempt")]
        [STJS.JsonPropertyName("registration_attempt")]
        public AccountActivityRegistrationAttempt RegistrationAttempt { get; set; }

        /// <summary>
        /// Details for the registration decision. Present only when type is registration_decision.
        /// </summary>
        [JsonProperty("registration_decision")]
        [STJS.JsonPropertyName("registration_decision")]
        public AccountActivityRegistrationDecision RegistrationDecision { get; set; }

        /// <summary>
        /// The type of activity.
        /// One of: <c>login_attempt</c>, <c>login_decision</c>, <c>registration_attempt</c>, or
        /// <c>registration_decision</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
