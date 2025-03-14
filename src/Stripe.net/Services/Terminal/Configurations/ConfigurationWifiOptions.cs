// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfigurationWifiOptions : INestedOptions
    {
        /// <summary>
        /// Credentials for a WPA-Enterprise WiFi network using the EAP-PEAP authentication method.
        /// </summary>
        [JsonProperty("enterprise_eap_peap")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enterprise_eap_peap")]
#endif
        public ConfigurationWifiEnterpriseEapPeapOptions EnterpriseEapPeap { get; set; }

        /// <summary>
        /// Credentials for a WPA-Enterprise WiFi network using the EAP-TLS authentication method.
        /// </summary>
        [JsonProperty("enterprise_eap_tls")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enterprise_eap_tls")]
#endif
        public ConfigurationWifiEnterpriseEapTlsOptions EnterpriseEapTls { get; set; }

        /// <summary>
        /// Credentials for a WPA-Personal WiFi network.
        /// </summary>
        [JsonProperty("personal_psk")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("personal_psk")]
#endif
        public ConfigurationWifiPersonalPskOptions PersonalPsk { get; set; }

        /// <summary>
        /// Security type of the WiFi network. Fill out the hash with the corresponding name to
        /// provide the set of credentials for this security type.
        /// One of: <c>enterprise_eap_peap</c>, <c>enterprise_eap_tls</c>, or <c>personal_psk</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
