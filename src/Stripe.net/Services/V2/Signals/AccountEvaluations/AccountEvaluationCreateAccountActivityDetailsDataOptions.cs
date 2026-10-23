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
        /// Required when type is account_takeover_confirmation. Requires an existing customer or
        /// account with a customer configuration.
        /// </summary>
        [JsonProperty("account_takeover_confirmation")]
        [STJS.JsonPropertyName("account_takeover_confirmation")]
        public AccountEvaluationCreateAccountActivityDetailsDataAccountTakeoverConfirmationOptions AccountTakeoverConfirmation { get; set; }

        /// <summary>
        /// Required when type is account_takeover_report. Requires an existing customer or account
        /// with a customer configuration.
        /// </summary>
        [JsonProperty("account_takeover_report")]
        [STJS.JsonPropertyName("account_takeover_report")]
        public AccountEvaluationCreateAccountActivityDetailsDataAccountTakeoverReportOptions AccountTakeoverReport { get; set; }

        /// <summary>
        /// Required when type is credential_change. Requires an existing customer or account with a
        /// customer configuration.
        /// </summary>
        [JsonProperty("credential_change")]
        [STJS.JsonPropertyName("credential_change")]
        public AccountEvaluationCreateAccountActivityDetailsDataCredentialChangeOptions CredentialChange { get; set; }

        /// <summary>
        /// Details for the login attempt. Provide only when type is login_attempt.
        /// </summary>
        [JsonProperty("login_attempt")]
        [STJS.JsonPropertyName("login_attempt")]
        public AccountEvaluationCreateAccountActivityDetailsDataLoginAttemptOptions LoginAttempt { get; set; }

        /// <summary>
        /// Required when type is mfa_addition. Requires an existing customer or account with a
        /// customer configuration.
        /// </summary>
        [JsonProperty("mfa_addition")]
        [STJS.JsonPropertyName("mfa_addition")]
        public AccountEvaluationCreateAccountActivityDetailsDataMfaAdditionOptions MfaAddition { get; set; }

        /// <summary>
        /// Required when type is mfa_removal. Requires an existing customer or account with a
        /// customer configuration.
        /// </summary>
        [JsonProperty("mfa_removal")]
        [STJS.JsonPropertyName("mfa_removal")]
        public AccountEvaluationCreateAccountActivityDetailsDataMfaRemovalOptions MfaRemoval { get; set; }

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
        /// The type of activity. Supports registration_attempt, login_attempt, mfa_addition,
        /// mfa_removal, credential_change, account_takeover_report, account_takeover_confirmation,
        /// or account_takeover_mitigation.
        /// One of: <c>account_restricted</c>, <c>account_reviewed</c>, <c>account_suspended</c>,
        /// <c>account_takeover_confirmation</c>, <c>account_takeover_mitigation</c>,
        /// <c>account_takeover_report</c>, <c>credential_change</c>,
        /// <c>custom_marketing_action</c>, <c>login_attempt</c>, <c>login_decision</c>,
        /// <c>mfa_addition</c>, <c>mfa_removal</c>, <c>registration_attempt</c>, or
        /// <c>registration_decision</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
