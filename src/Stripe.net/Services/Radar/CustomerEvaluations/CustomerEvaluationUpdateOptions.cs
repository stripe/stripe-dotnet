// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CustomerEvaluationUpdateOptions : BaseOptions
    {
        /// <summary>
        /// Event payload for login_failed.
        /// </summary>
        [JsonProperty("login_failed")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("login_failed")]
#endif
        public CustomerEvaluationLoginFailedOptions LoginFailed { get; set; }

        /// <summary>
        /// Event payload for registration_failed.
        /// </summary>
        [JsonProperty("registration_failed")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("registration_failed")]
#endif
        public CustomerEvaluationRegistrationFailedOptions RegistrationFailed { get; set; }

        /// <summary>
        /// Event payload for registration_success.
        /// </summary>
        [JsonProperty("registration_success")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("registration_success")]
#endif
        public CustomerEvaluationRegistrationSuccessOptions RegistrationSuccess { get; set; }

        /// <summary>
        /// The type of event to report.
        /// One of: <c>login_failed</c>, <c>login_success</c>, <c>registration_failed</c>, or
        /// <c>registration_success</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
