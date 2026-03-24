// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ConfigurationCreateOptions : BaseOptions
    {
        private ConfigurationCellularOptions cellular;
        private ConfigurationOfflineOptions offline;
        private ConfigurationTippingOptions tipping;
        private ConfigurationWifiOptions wifi;

        /// <summary>
        /// An object containing device type specific settings for BBPOS WisePad 3 readers.
        /// </summary>
        [JsonProperty("bbpos_wisepad3")]
        [STJS.JsonPropertyName("bbpos_wisepad3")]
        public ConfigurationBbposWisepad3Options BbposWisepad3 { get; set; }

        /// <summary>
        /// An object containing device type specific settings for BBPOS WisePOS E readers.
        /// </summary>
        [JsonProperty("bbpos_wisepos_e")]
        [STJS.JsonPropertyName("bbpos_wisepos_e")]
        public ConfigurationBbposWiseposEOptions BbposWiseposE { get; set; }

        /// <summary>
        /// Configuration for cellular connectivity.
        /// </summary>
        [JsonProperty("cellular")]
        [STJS.JsonPropertyName("cellular")]
        public ConfigurationCellularOptions Cellular
        {
            get => this.cellular;
            set
            {
                this.cellular = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Name of the configuration.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Configurations for collecting transactions offline.
        /// </summary>
        [JsonProperty("offline")]
        [STJS.JsonPropertyName("offline")]
        public ConfigurationOfflineOptions Offline
        {
            get => this.offline;
            set
            {
                this.offline = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Reboot time settings for readers. that support customized reboot time configuration.
        /// </summary>
        [JsonProperty("reboot_window")]
        [STJS.JsonPropertyName("reboot_window")]
        public ConfigurationRebootWindowOptions RebootWindow { get; set; }

        /// <summary>
        /// An object containing device type specific settings for Stripe S700 readers.
        /// </summary>
        [JsonProperty("stripe_s700")]
        [STJS.JsonPropertyName("stripe_s700")]
        public ConfigurationStripeS700Options StripeS700 { get; set; }

        /// <summary>
        /// An object containing device type specific settings for Stripe S710 readers.
        /// </summary>
        [JsonProperty("stripe_s710")]
        [STJS.JsonPropertyName("stripe_s710")]
        public ConfigurationStripeS710Options StripeS710 { get; set; }

        /// <summary>
        /// Tipping configurations for readers that support on-reader tips.
        /// </summary>
        [JsonProperty("tipping")]
        [STJS.JsonPropertyName("tipping")]
        public ConfigurationTippingOptions Tipping
        {
            get => this.tipping;
            set
            {
                this.tipping = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// An object containing device type specific settings for Verifone P400 readers.
        /// </summary>
        [JsonProperty("verifone_p400")]
        [STJS.JsonPropertyName("verifone_p400")]
        public ConfigurationVerifoneP400Options VerifoneP400 { get; set; }

        /// <summary>
        /// Configurations for connecting to a WiFi network.
        /// </summary>
        [JsonProperty("wifi")]
        [STJS.JsonPropertyName("wifi")]
        public ConfigurationWifiOptions Wifi
        {
            get => this.wifi;
            set
            {
                this.wifi = value;
                this.SetTracker.Track();
            }
        }
    }
}
