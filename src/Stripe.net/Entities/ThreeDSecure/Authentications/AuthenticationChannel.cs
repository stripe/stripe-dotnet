// File generated from our OpenAPI spec
namespace Stripe.ThreeDSecure
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthenticationChannel : StripeEntity<AuthenticationChannel>
    {
        /// <summary>
        /// Contains details on the browser for a standalone 3DS Authentication.
        /// </summary>
        [JsonProperty("browser")]
        [STJS.JsonPropertyName("browser")]
        public AuthenticationChannelBrowser Browser { get; set; }

        /// <summary>
        /// Contains details for a 3RI standalone 3DS Authentication.
        /// </summary>
        [JsonProperty("three_r_i")]
        [STJS.JsonPropertyName("three_r_i")]
        public AuthenticationChannelThreeRI ThreeRI { get; set; }

        /// <summary>
        /// Type of channel you would prefer to use for this 3DS Authentication. Only browser.
        /// One of: <c>browser</c>, or <c>three_r_i</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
