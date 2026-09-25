// File generated from our OpenAPI spec
namespace Stripe.ThreeDSecure
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AuthenticationChannelOptions : INestedOptions
    {
        /// <summary>
        /// Contains additional details about the browser details you collected.
        /// </summary>
        [JsonProperty("browser")]
        [STJS.JsonPropertyName("browser")]
        public AuthenticationChannelBrowserOptions Browser { get; set; }

        /// <summary>
        /// Contains additional details about the 3DS Requestor Initiated (3RI) channel.
        /// </summary>
        [JsonProperty("three_r_i")]
        [STJS.JsonPropertyName("three_r_i")]
        public AuthenticationChannelThreeRIOptions ThreeRI { get; set; }

        /// <summary>
        /// Type of channel you would prefer to use for this 3DS Authentication.
        /// One of: <c>browser</c>, or <c>three_r_i</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
