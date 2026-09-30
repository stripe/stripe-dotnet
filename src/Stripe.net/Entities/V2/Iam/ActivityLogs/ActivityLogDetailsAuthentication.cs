// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ActivityLogDetailsAuthentication : StripeEntity<ActivityLogDetailsAuthentication>
    {
        /// <summary>
        /// Backup email address involved in the authentication.
        /// </summary>
        [JsonProperty("backup_email")]
        [STJS.JsonPropertyName("backup_email")]
        public string BackupEmail { get; set; }

        /// <summary>
        /// Type of challenge used for the authentication.
        /// One of: <c>external_account_code</c>, <c>oauth</c>, <c>previous_account_number</c>,
        /// <c>reverse_sms</c>, <c>sms</c>, <c>stripe_identity</c>, <c>totp</c>, or <c>webauthn</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("challenge_type")]
        [STJS.JsonPropertyName("challenge_type")]
        public string ChallengeType { get; set; }

        /// <summary>
        /// Surface where the authentication occurred.
        /// One of: <c>dashboard</c>, or <c>express</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("surface")]
        [STJS.JsonPropertyName("surface")]
        public string Surface { get; set; }

        /// <summary>
        /// Target email address involved in the authentication.
        /// </summary>
        [JsonProperty("target_email")]
        [STJS.JsonPropertyName("target_email")]
        public string TargetEmail { get; set; }
    }
}
