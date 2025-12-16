// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountEvaluationCreateOptions : BaseOptions
    {
        /// <summary>
        /// Event payload for login_initiated.
        /// </summary>
        [JsonProperty("login_initiated")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("login_initiated")]
#endif
        public AccountEvaluationLoginInitiatedOptions LoginInitiated { get; set; }

        /// <summary>
        /// Event payload for registration_initiated.
        /// </summary>
        [JsonProperty("registration_initiated")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("registration_initiated")]
#endif
        public AccountEvaluationRegistrationInitiatedOptions RegistrationInitiated { get; set; }

        /// <summary>
        /// The type of evaluation requested.
        /// One of: <c>login_initiated</c>, or <c>registration_initiated</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
