// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// A Configurations object represents how features should be configured for terminal
    /// readers.
    /// </summary>
    public class Configuration : StripeEntity<Configuration>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif

        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif

        public string Object { get; set; }

        [JsonProperty("bbpos_wisepos_e")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bbpos_wisepos_e")]
#endif

        public ConfigurationBbposWiseposE BbposWiseposE { get; set; }

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("deleted")]
#endif

        public bool? Deleted { get; set; }

        /// <summary>
        /// Whether this Configuration is the default for your account.
        /// </summary>
        [JsonProperty("is_account_default")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("is_account_default")]
#endif

        public bool? IsAccountDefault { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif

        public bool Livemode { get; set; }

        /// <summary>
        /// String indicating the name of the Configuration object, set by the user.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif

        public string Name { get; set; }

        [JsonProperty("offline")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("offline")]
#endif

        public ConfigurationOffline Offline { get; set; }

        [JsonProperty("reboot_window")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reboot_window")]
#endif

        public ConfigurationRebootWindow RebootWindow { get; set; }

        [JsonProperty("stripe_s700")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("stripe_s700")]
#endif

        public ConfigurationStripeS700 StripeS700 { get; set; }

        [JsonProperty("tipping")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tipping")]
#endif

        public ConfigurationTipping Tipping { get; set; }

        [JsonProperty("verifone_p400")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("verifone_p400")]
#endif

        public ConfigurationVerifoneP400 VerifoneP400 { get; set; }
    }
}
