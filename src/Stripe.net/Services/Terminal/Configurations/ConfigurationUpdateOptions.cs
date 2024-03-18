// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class ConfigurationUpdateOptions : BaseOptions
    {
        /// <summary>
        /// An object containing device type specific settings for BBPOS WisePOS E readers.
        /// </summary>
        [JsonProperty("bbpos_wisepos_e")]
        public ConfigurationBbposWiseposEOptions BbposWiseposE { get; set; }

        /// <summary>
        /// Name of the configuration.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Configurations for collecting transactions offline.
        /// </summary>
        [JsonProperty("offline")]
        public ConfigurationOfflineOptions Offline { get; set; }

        /// <summary>
        /// Tipping configurations for readers supporting on-reader tips.
        /// </summary>
        [JsonProperty("tipping")]
        public ConfigurationTippingOptions Tipping { get; set; }

        /// <summary>
        /// An object containing device type specific settings for Verifone P400 readers.
        /// </summary>
        [JsonProperty("verifone_p400")]
        public ConfigurationVerifoneP400Options VerifoneP400 { get; set; }
    }
}
