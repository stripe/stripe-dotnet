// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfigurationUpdateOptions : BaseOptions
    {
        /// <summary>
        /// An object containing device type specific settings for BBPOS WisePOS E readers.
        /// </summary>
        [JsonProperty("bbpos_wisepos_e")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bbpos_wisepos_e")]
#endif
        public ConfigurationBbposWiseposEOptions BbposWiseposE { get; set; }

        /// <summary>
        /// Name of the configuration.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }

        /// <summary>
        /// Configurations for collecting transactions offline.
        /// </summary>
        [JsonProperty("offline")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("offline")]
#endif
        public ConfigurationOfflineOptions Offline { get; set; }

        /// <summary>
        /// Configurations for reader security settings.
        /// </summary>
        [JsonProperty("reader_security")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reader_security")]
#endif
        public ConfigurationReaderSecurityOptions ReaderSecurity { get; set; }

        /// <summary>
        /// Reboot time settings for readers that support customized reboot time configuration.
        /// </summary>
        [JsonProperty("reboot_window")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reboot_window")]
#endif
        public ConfigurationRebootWindowOptions RebootWindow { get; set; }

        /// <summary>
        /// An object containing device type specific settings for Stripe S700 readers.
        /// </summary>
        [JsonProperty("stripe_s700")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("stripe_s700")]
#endif
        public ConfigurationStripeS700Options StripeS700 { get; set; }

        /// <summary>
        /// Tipping configurations for readers supporting on-reader tips.
        /// </summary>
        [JsonProperty("tipping")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tipping")]
#endif
        public ConfigurationTippingOptions Tipping { get; set; }

        /// <summary>
        /// An object containing device type specific settings for Verifone P400 readers.
        /// </summary>
        [JsonProperty("verifone_p400")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("verifone_p400")]
#endif
        public ConfigurationVerifoneP400Options VerifoneP400 { get; set; }

        /// <summary>
        /// Configurations for connecting to a WiFi network.
        /// </summary>
        [JsonProperty("wifi")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("wifi")]
#endif
        public ConfigurationWifiOptions Wifi { get; set; }
    }
}
