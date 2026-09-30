// File generated from our OpenAPI spec
namespace Stripe.ThreeDSecure
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AuthenticationFlowPreferenceOptions : INestedOptions
    {
        /// <summary>
        /// Contains additional details about your challenge flow preference for this 3DS
        /// Authentication.
        /// </summary>
        [JsonProperty("challenge")]
        [STJS.JsonPropertyName("challenge")]
        public AuthenticationFlowPreferenceChallengeOptions Challenge { get; set; }

        /// <summary>
        /// Contains additional details about your data share only flow preference for this 3DS
        /// Authentication.
        /// </summary>
        [JsonProperty("data_share")]
        [STJS.JsonPropertyName("data_share")]
        public AuthenticationFlowPreferenceDataShareOptions DataShare { get; set; }

        /// <summary>
        /// Contains additional details about your frictionless flow preference for this 3DS
        /// Authentication.
        /// </summary>
        [JsonProperty("frictionless")]
        [STJS.JsonPropertyName("frictionless")]
        public AuthenticationFlowPreferenceFrictionlessOptions Frictionless { get; set; }

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
