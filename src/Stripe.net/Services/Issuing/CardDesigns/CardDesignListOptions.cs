// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CardDesignListOptions : ListOptions
    {
        /// <summary>
        /// Only return card designs with the given lookup keys.
        /// </summary>
        [JsonProperty("lookup_keys")]
        public List<string> LookupKeys { get; set; }

        /// <summary>
        /// Only return card designs with the given preferences.
        /// </summary>
        [JsonProperty("preferences")]
        public CardDesignPreferencesOptions Preferences { get; set; }

        /// <summary>
        /// Only return card designs with the given status.
        /// One of: <c>active</c>, <c>inactive</c>, <c>rejected</c>, or <c>review</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
