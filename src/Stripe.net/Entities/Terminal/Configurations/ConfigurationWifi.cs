// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ConfigurationWifi : StripeEntity<ConfigurationWifi>
    {
        [JsonProperty("enterprise_eap_peap")]
        [STJS.JsonPropertyName("enterprise_eap_peap")]
        public ConfigurationWifiEnterpriseEapPeap EnterpriseEapPeap { get; set; }

        [JsonProperty("enterprise_eap_tls")]
        [STJS.JsonPropertyName("enterprise_eap_tls")]
        public ConfigurationWifiEnterpriseEapTls EnterpriseEapTls { get; set; }

        [JsonProperty("personal_psk")]
        [STJS.JsonPropertyName("personal_psk")]
        public ConfigurationWifiPersonalPsk PersonalPsk { get; set; }

        /// <summary>
        /// Security type of the WiFi network. The hash with the corresponding name contains the
        /// credentials for this security type.
        /// One of: <c>enterprise_eap_peap</c>, <c>enterprise_eap_tls</c>, or <c>personal_psk</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
