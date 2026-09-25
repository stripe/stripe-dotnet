// File generated from our OpenAPI spec
namespace Stripe.ThreeDSecure
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthenticationFlowPreference : StripeEntity<AuthenticationFlowPreference>
    {
        [JsonProperty("challenge")]
        [STJS.JsonPropertyName("challenge")]
        public AuthenticationFlowPreferenceChallenge Challenge { get; set; }

        [JsonProperty("data_share")]
        [STJS.JsonPropertyName("data_share")]
        public AuthenticationFlowPreferenceDataShare DataShare { get; set; }

        [JsonProperty("frictionless")]
        [STJS.JsonPropertyName("frictionless")]
        public AuthenticationFlowPreferenceFrictionless Frictionless { get; set; }

        /// <summary>
        /// Type of flow you requested for this 3DS Authentication.
        /// One of: <c>challenge</c>, <c>data_share</c>, or <c>frictionless</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
