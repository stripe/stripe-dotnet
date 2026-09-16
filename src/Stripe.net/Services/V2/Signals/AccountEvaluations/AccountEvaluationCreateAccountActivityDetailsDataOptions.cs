// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountEvaluationCreateAccountActivityDetailsDataOptions : INestedOptions
    {
        /// <summary>
        /// Details for the login attempt. Provide only when type is login_attempt.
        /// </summary>
        [JsonProperty("login_attempt")]
        [STJS.JsonPropertyName("login_attempt")]
        public AccountEvaluationCreateAccountActivityDetailsDataLoginAttemptOptions LoginAttempt { get; set; }

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
        public AccountEvaluationCreateAccountActivityDetailsDataRegistrationAttemptOptions RegistrationAttempt { get; set; }

        /// <summary>
        /// The type of activity. Must be registration_attempt or login_attempt.
        /// One of: <c>login_attempt</c>, <c>login_decision</c>, <c>registration_attempt</c>, or
        /// <c>registration_decision</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
