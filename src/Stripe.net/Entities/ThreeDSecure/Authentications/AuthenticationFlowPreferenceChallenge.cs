// File generated from our OpenAPI spec
namespace Stripe.ThreeDSecure
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthenticationFlowPreferenceChallenge : StripeEntity<AuthenticationFlowPreferenceChallenge>
    {
        /// <summary>
        /// Type of challenge flow you requested for this 3DS Authentication.
        /// One of: <c>mandated</c>, or <c>preferred</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
