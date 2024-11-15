// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PersonalizationDesignListOptions : ListOptions
    {
        /// <summary>
        /// Only return personalization designs with the given lookup keys.
        /// </summary>
        [JsonProperty("lookup_keys")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lookup_keys")]
#endif

        public List<string> LookupKeys { get; set; }

        /// <summary>
        /// Only return personalization designs with the given preferences.
        /// </summary>
        [JsonProperty("preferences")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("preferences")]
#endif

        public PersonalizationDesignPreferencesOptions Preferences { get; set; }

        /// <summary>
        /// Only return personalization designs with the given status.
        /// One of: <c>active</c>, <c>inactive</c>, <c>rejected</c>, or <c>review</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif

        public string Status { get; set; }
    }
}
