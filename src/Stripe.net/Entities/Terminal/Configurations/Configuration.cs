// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A Configurations object represents how features should be configured for terminal
    /// readers. For information about how to use it, see the <a
    /// href="https://docs.stripe.com/terminal/fleet/configurations-overview">Terminal
    /// configurations documentation</a>.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Configuration : StripeEntity<Configuration>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        [JsonProperty("bbpos_wisepad3")]
        [STJS.JsonPropertyName("bbpos_wisepad3")]
        public ConfigurationBbposWisepad3 BbposWisepad3 { get; set; }

        [JsonProperty("bbpos_wisepos_e")]
        [STJS.JsonPropertyName("bbpos_wisepos_e")]
        public ConfigurationBbposWiseposE BbposWiseposE { get; set; }

        [JsonProperty("cellular")]
        [STJS.JsonPropertyName("cellular")]
        public ConfigurationCellular Cellular { get; set; }

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("deleted")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Whether this Configuration is the default for your account.
        /// </summary>
        [JsonProperty("is_account_default")]
        [STJS.JsonPropertyName("is_account_default")]
        public bool? IsAccountDefault { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// String indicating the name of the Configuration object, set by the user.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonProperty("offline")]
        [STJS.JsonPropertyName("offline")]
        public ConfigurationOffline Offline { get; set; }

        [JsonProperty("reboot_window")]
        [STJS.JsonPropertyName("reboot_window")]
        public ConfigurationRebootWindow RebootWindow { get; set; }

        [JsonProperty("stripe_s700")]
        [STJS.JsonPropertyName("stripe_s700")]
        public ConfigurationStripeS700 StripeS700 { get; set; }

        [JsonProperty("stripe_s710")]
        [STJS.JsonPropertyName("stripe_s710")]
        public ConfigurationStripeS710 StripeS710 { get; set; }

        [JsonProperty("tipping")]
        [STJS.JsonPropertyName("tipping")]
        public ConfigurationTipping Tipping { get; set; }

        [JsonProperty("verifone_p400")]
        [STJS.JsonPropertyName("verifone_p400")]
        public ConfigurationVerifoneP400 VerifoneP400 { get; set; }

        [JsonProperty("wifi")]
        [STJS.JsonPropertyName("wifi")]
        public ConfigurationWifi Wifi { get; set; }
    }
}
