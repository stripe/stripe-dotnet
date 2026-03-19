// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ConfigurationWifiEnterpriseEapTlsOptions : INestedOptions
    {
        /// <summary>
        /// A File ID representing a PEM file containing the server certificate.
        /// </summary>
        [JsonProperty("ca_certificate_file")]
        [STJS.JsonPropertyName("ca_certificate_file")]
        public string CaCertificateFile { get; set; }

        /// <summary>
        /// A File ID representing a PEM file containing the client certificate.
        /// </summary>
        [JsonProperty("client_certificate_file")]
        [STJS.JsonPropertyName("client_certificate_file")]
        public string ClientCertificateFile { get; set; }

        /// <summary>
        /// A File ID representing a PEM file containing the client RSA private key.
        /// </summary>
        [JsonProperty("private_key_file")]
        [STJS.JsonPropertyName("private_key_file")]
        public string PrivateKeyFile { get; set; }

        /// <summary>
        /// Password for the private key file.
        /// </summary>
        [JsonProperty("private_key_file_password")]
        [STJS.JsonPropertyName("private_key_file_password")]
        public string PrivateKeyFilePassword { get; set; }

        /// <summary>
        /// Name of the WiFi network.
        /// </summary>
        [JsonProperty("ssid")]
        [STJS.JsonPropertyName("ssid")]
        public string Ssid { get; set; }
    }
}
