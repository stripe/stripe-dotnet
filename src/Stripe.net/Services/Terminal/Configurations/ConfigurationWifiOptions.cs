// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ConfigurationWifiOptions : INestedOptions
    {
        /// <summary>
        /// Credentials for a WPA-Enterprise WiFi network using the EAP-PEAP authentication method.
        /// </summary>
        [JsonProperty("enterprise_eap_peap")]
        [STJS.JsonPropertyName("enterprise_eap_peap")]
        public ConfigurationWifiEnterpriseEapPeapOptions EnterpriseEapPeap { get; set; }

        /// <summary>
        /// Credentials for a WPA-Enterprise WiFi network using the EAP-TLS authentication method.
        /// </summary>
        [JsonProperty("enterprise_eap_tls")]
        [STJS.JsonPropertyName("enterprise_eap_tls")]
        public ConfigurationWifiEnterpriseEapTlsOptions EnterpriseEapTls { get; set; }

        /// <summary>
        /// Credentials for a WPA-Personal WiFi network.
        /// </summary>
        [JsonProperty("personal_psk")]
        [STJS.JsonPropertyName("personal_psk")]
        public ConfigurationWifiPersonalPskOptions PersonalPsk { get; set; }

        /// <summary>
        /// Security type of the WiFi network. Fill out the hash with the corresponding name to
        /// provide the set of credentials for this security type.
        /// One of: <c>enterprise_eap_peap</c>, <c>enterprise_eap_tls</c>, or <c>personal_psk</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
