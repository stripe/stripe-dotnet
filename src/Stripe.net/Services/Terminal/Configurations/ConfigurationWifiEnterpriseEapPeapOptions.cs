// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ConfigurationWifiEnterpriseEapPeapOptions : INestedOptions
    {
        /// <summary>
        /// A File ID representing a PEM file containing the server certificate.
        /// </summary>
        [JsonProperty("ca_certificate_file")]
        [STJS.JsonPropertyName("ca_certificate_file")]
        public string CaCertificateFile { get; set; }

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

        /// <summary>
        /// Username for connecting to the WiFi network.
        /// </summary>
        [JsonProperty("username")]
        [STJS.JsonPropertyName("username")]
        public string Username { get; set; }
    }
}
