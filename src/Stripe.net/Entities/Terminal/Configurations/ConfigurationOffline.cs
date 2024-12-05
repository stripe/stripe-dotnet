// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class ConfigurationOffline : StripeEntity<ConfigurationOffline>
    {
        /// <summary>
        /// Determines whether to allow transactions to be collected while reader is offline.
        /// Defaults to false.
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
    }
}
