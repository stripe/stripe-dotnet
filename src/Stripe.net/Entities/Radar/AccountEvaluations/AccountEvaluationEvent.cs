// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountEvaluationEvent : StripeEntity<AccountEvaluationEvent>
    {
        /// <summary>
        /// Data about a failed login event.
        /// </summary>
        [JsonProperty("login_failed")]
        [STJS.JsonPropertyName("login_failed")]
        public AccountEvaluationEventLoginFailed LoginFailed { get; set; }

        /// <summary>
        /// Time at which the event occurred. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("occurred_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("occurred_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime OccurredAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Data about a failed registration event.
        /// </summary>
        [JsonProperty("registration_failed")]
        [STJS.JsonPropertyName("registration_failed")]
        public AccountEvaluationEventRegistrationFailed RegistrationFailed { get; set; }

        /// <summary>
        /// The type of event that occurred.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
