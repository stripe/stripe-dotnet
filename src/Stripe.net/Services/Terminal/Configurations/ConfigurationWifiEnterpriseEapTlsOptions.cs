// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfigurationWifiEnterpriseEapTlsOptions : INestedOptions
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
        /// A File ID representing a PEM file containing the client certificate.
        /// </summary>
        [JsonProperty("client_certificate_file")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("client_certificate_file")]
#endif
        public string ClientCertificateFile { get; set; }

        /// <summary>
        /// A File ID representing a PEM file containing the client RSA private key.
        /// </summary>
        [JsonProperty("private_key_file")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("private_key_file")]
#endif
        public string PrivateKeyFile { get; set; }

        /// <summary>
        /// Password for the private key file.
        /// </summary>
        [JsonProperty("private_key_file_password")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("private_key_file_password")]
#endif
        public string PrivateKeyFilePassword { get; set; }

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
