// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountActivityCreateOptions : BaseOptions
    {
        /// <summary>
        /// The account, customer, or inline account data associated with the activity.
        /// </summary>
        [JsonProperty("account_details")]
        [STJS.JsonPropertyName("account_details")]
        public AccountActivityCreateAccountDetailsOptions AccountDetails { get; set; }

        /// <summary>
        /// The account evaluation this activity is associated with, when applicable.
        /// </summary>
        [JsonProperty("account_evaluation")]
        [STJS.JsonPropertyName("account_evaluation")]
        public string AccountEvaluation { get; set; }

        /// <summary>
        /// Details for the login attempt. Provide only when type is login_attempt.
        /// </summary>
        [JsonProperty("login_attempt")]
        [STJS.JsonPropertyName("login_attempt")]
        public AccountActivityCreateLoginAttemptOptions LoginAttempt { get; set; }

        /// <summary>
        /// Details for the login decision. Provide only when type is login_decision.
        /// </summary>
        [JsonProperty("login_decision")]
        [STJS.JsonPropertyName("login_decision")]
        public AccountActivityCreateLoginDecisionOptions LoginDecision { get; set; }

        /// <summary>
        /// Timestamp at which the activity occurred. Defaults to the created time if not provided.
        /// </summary>
        [JsonProperty("occurred_at")]
        [STJS.JsonPropertyName("occurred_at")]
        public DateTime? OccurredAt { get; set; }

        /// <summary>
        /// Details for the registration attempt. Provide only when type is registration_attempt.
        /// </summary>
        [JsonProperty("registration_attempt")]
        [STJS.JsonPropertyName("registration_attempt")]
        public AccountActivityCreateRegistrationAttemptOptions RegistrationAttempt { get; set; }

        /// <summary>
        /// Details for the registration decision. Provide only when type is registration_decision.
        /// </summary>
        [JsonProperty("registration_decision")]
        [STJS.JsonPropertyName("registration_decision")]
        public AccountActivityCreateRegistrationDecisionOptions RegistrationDecision { get; set; }

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
