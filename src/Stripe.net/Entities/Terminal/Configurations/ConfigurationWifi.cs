// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfigurationWifi : StripeEntity<ConfigurationWifi>
    {
        [JsonProperty("enterprise_eap_peap")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enterprise_eap_peap")]
#endif
        public ConfigurationWifiEnterpriseEapPeap EnterpriseEapPeap { get; set; }

        [JsonProperty("enterprise_eap_tls")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enterprise_eap_tls")]
#endif
        public ConfigurationWifiEnterpriseEapTls EnterpriseEapTls { get; set; }

        [JsonProperty("personal_psk")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("personal_psk")]
#endif
        public ConfigurationWifiPersonalPsk PersonalPsk { get; set; }

        /// <summary>
        /// Security type of the WiFi network. The hash with the corresponding name contains the
        /// credentials for this security type.
        /// One of: <c>enterprise_eap_peap</c>, <c>enterprise_eap_tls</c>, or <c>personal_psk</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
