// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfigurationWifiEnterpriseEapPeapOptions : INestedOptions
    {
        /// <summary>
        /// A File ID representing a PEM file containing the server certificate.
        /// </summary>
        [JsonProperty("ca_certificate_file")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ca_certificate_file")]
#endif
        public string CaCertificateFile { get; set; }

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

        /// <summary>
        /// Username for connecting to the WiFi network.
        /// </summary>
        [JsonProperty("username")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("username")]
#endif
        public string Username { get; set; }
    }
}
