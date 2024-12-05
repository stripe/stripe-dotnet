// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;

    public class ConfigurationListOptions : ListOptions
    {
        /// <summary>
        /// Only return configurations that are active or inactive (e.g., pass <c>true</c> to only
        /// list active configurations).
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Only return the default or non-default configurations (e.g., pass <c>true</c> to only
        /// list the default configuration).
        /// </summary>
        [JsonProperty("is_default")]
        public bool? IsDefault { get; set; }
    }
}
