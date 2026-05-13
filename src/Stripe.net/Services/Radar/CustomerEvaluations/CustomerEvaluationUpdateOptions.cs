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
        /// The ID of a Customer to attach to an entity-less registration evaluation.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// Data for a failed login event.
        /// </summary>
        [JsonProperty("login_failed")]
        [STJS.JsonPropertyName("login_failed")]
        public CustomerEvaluationLoginFailedOptions LoginFailed { get; set; }

        /// <summary>
        /// Data for a failed registration event.
        /// </summary>
        [JsonProperty("registration_failed")]
        [STJS.JsonPropertyName("registration_failed")]
        public CustomerEvaluationRegistrationFailedOptions RegistrationFailed { get; set; }

        /// <summary>
        /// Data for a successful registration event.
        /// </summary>
        [JsonProperty("registration_success")]
        [STJS.JsonPropertyName("registration_success")]
        public CustomerEvaluationRegistrationSuccessOptions RegistrationSuccess { get; set; }

        /// <summary>
        /// The outcome status of the evaluation: allowed, restricted, or blocked.
        /// One of: <c>allowed</c>, <c>blocked</c>, or <c>restricted</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// The type of event to report on the customer evaluation.
        /// One of: <c>login_failed</c>, <c>login_success</c>, <c>registration_failed</c>, or
        /// <c>registration_success</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
