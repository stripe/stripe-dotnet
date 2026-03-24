// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CustomerEvaluationUpdateOptions : BaseOptions
    {
        /// <summary>
        /// Event payload for login_failed.
        /// </summary>
        [JsonProperty("login_failed")]
        [STJS.JsonPropertyName("login_failed")]
        public CustomerEvaluationLoginFailedOptions LoginFailed { get; set; }

        /// <summary>
        /// Event payload for registration_failed.
        /// </summary>
        [JsonProperty("registration_failed")]
        [STJS.JsonPropertyName("registration_failed")]
        public CustomerEvaluationRegistrationFailedOptions RegistrationFailed { get; set; }

        /// <summary>
        /// Event payload for registration_success.
        /// </summary>
        [JsonProperty("registration_success")]
        [STJS.JsonPropertyName("registration_success")]
        public CustomerEvaluationRegistrationSuccessOptions RegistrationSuccess { get; set; }

        /// <summary>
        /// The type of event to report.
        /// One of: <c>login_failed</c>, <c>login_success</c>, <c>registration_failed</c>, or
        /// <c>registration_success</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
