// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ConfigurationUpdateOptions : BaseOptions
    {
        private ConfigurationBbposWisepad3Options bbposWisepad3;
        private ConfigurationBbposWiseposEOptions bbposWiseposE;
        private ConfigurationCellularOptions cellular;
        private ConfigurationOfflineOptions offline;
        private ConfigurationReaderSecurityOptions readerSecurity;
        private ConfigurationRebootWindowOptions rebootWindow;
        private ConfigurationStripeS700Options stripeS700;
        private ConfigurationStripeS710Options stripeS710;
        private ConfigurationTippingOptions tipping;
        private ConfigurationVerifoneP400Options verifoneP400;
        private ConfigurationWifiOptions wifi;

        /// <summary>
        /// An object containing device type specific settings for BBPOS WisePad 3 readers.
        /// </summary>
        [JsonProperty("bbpos_wisepad3", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("bbpos_wisepad3")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public ConfigurationBbposWisepad3Options BbposWisepad3
        {
            get => this.bbposWisepad3;
            set
            {
                this.bbposWisepad3 = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// An object containing device type specific settings for BBPOS WisePOS E readers.
        /// </summary>
        [JsonProperty("bbpos_wisepos_e", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("bbpos_wisepos_e")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public ConfigurationBbposWiseposEOptions BbposWiseposE
        {
            get => this.bbposWiseposE;
            set
            {
                this.bbposWiseposE = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Configuration for cellular connectivity.
        /// </summary>
        [JsonProperty("cellular", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("cellular")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
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
        [JsonProperty("offline", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("offline")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
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
        /// Configurations for reader security settings.
        /// </summary>
        [JsonProperty("reader_security")]
        [STJS.JsonPropertyName("reader_security")]
        public ConfigurationReaderSecurityOptions ReaderSecurity
        {
            get => this.readerSecurity;
            set
            {
                this.readerSecurity = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Reboot time settings for readers. that support customized reboot time configuration.
        /// </summary>
        [JsonProperty("reboot_window", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("reboot_window")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public ConfigurationRebootWindowOptions RebootWindow
        {
            get => this.rebootWindow;
            set
            {
                this.rebootWindow = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// An object containing device type specific settings for Stripe S700 readers.
        /// </summary>
        [JsonProperty("stripe_s700", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("stripe_s700")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public ConfigurationStripeS700Options StripeS700
        {
            get => this.stripeS700;
            set
            {
                this.stripeS700 = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// An object containing device type specific settings for Stripe S710 readers.
        /// </summary>
        [JsonProperty("stripe_s710", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("stripe_s710")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public ConfigurationStripeS710Options StripeS710
        {
            get => this.stripeS710;
            set
            {
                this.stripeS710 = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Tipping configurations for readers that support on-reader tips.
        /// </summary>
        [JsonProperty("tipping", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("tipping")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
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
        [JsonProperty("verifone_p400", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("verifone_p400")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public ConfigurationVerifoneP400Options VerifoneP400
        {
            get => this.verifoneP400;
            set
            {
                this.verifoneP400 = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Configurations for connecting to a WiFi network.
        /// </summary>
        [JsonProperty("wifi", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("wifi")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
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
