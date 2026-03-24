// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountEvaluationCreateOptions : BaseOptions
    {
        /// <summary>
        /// Event payload for login_initiated.
        /// </summary>
        [JsonProperty("login_initiated")]
        [STJS.JsonPropertyName("login_initiated")]
        public AccountEvaluationLoginInitiatedOptions LoginInitiated { get; set; }

        /// <summary>
        /// Event payload for registration_initiated.
        /// </summary>
        [JsonProperty("registration_initiated")]
        [STJS.JsonPropertyName("registration_initiated")]
        public AccountEvaluationRegistrationInitiatedOptions RegistrationInitiated { get; set; }

        /// <summary>
        /// The type of evaluation requested.
        /// One of: <c>login_initiated</c>, or <c>registration_initiated</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
