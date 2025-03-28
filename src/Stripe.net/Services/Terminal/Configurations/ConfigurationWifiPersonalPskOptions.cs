// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfigurationWifiPersonalPskOptions : INestedOptions
    {
        /// <summary>
        /// Password for connecting to the WiFi network.
        /// </summary>
        [JsonProperty("password")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("password")]
#endif
        public string Password { get; set; }

        /// <summary>
        /// Name of the WiFi network.
        /// </summary>
        [JsonProperty("ssid")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ssid")]
#endif
        public string Ssid { get; set; }
    }
}
