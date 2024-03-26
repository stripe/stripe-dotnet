// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;

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
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("bbpos_wisepos_e")]
        public ConfigurationBbposWiseposE BbposWiseposE { get; set; }

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Whether this Configuration is the default for your account.
        /// </summary>
        [JsonProperty("is_account_default")]
        public bool? IsAccountDefault { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// String indicating the name of the Configuration object, set by the user.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("offline")]
        public ConfigurationOffline Offline { get; set; }

        [JsonProperty("tipping")]
        public ConfigurationTipping Tipping { get; set; }

        [JsonProperty("verifone_p400")]
        public ConfigurationVerifoneP400 VerifoneP400 { get; set; }
    }
}
