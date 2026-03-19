// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ConfigurationWifiPersonalPsk : StripeEntity<ConfigurationWifiPersonalPsk>
    {
        /// <summary>
        /// Password for connecting to the WiFi network.
        /// </summary>
        [JsonProperty("password")]
        [STJS.JsonPropertyName("password")]
        public string Password { get; set; }

        /// <summary>
        /// Name of the WiFi network.
        /// </summary>
        [JsonProperty("ssid")]
        [STJS.JsonPropertyName("ssid")]
        public string Ssid { get; set; }
    }
}
