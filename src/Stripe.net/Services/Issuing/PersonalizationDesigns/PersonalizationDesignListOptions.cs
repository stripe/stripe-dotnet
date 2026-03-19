// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PersonalizationDesignListOptions : ListOptions
    {
        /// <summary>
        /// Only return personalization designs with the given lookup keys.
        /// </summary>
        [JsonProperty("lookup_keys")]
        [STJS.JsonPropertyName("lookup_keys")]
        public List<string> LookupKeys { get; set; }

        /// <summary>
        /// Only return personalization designs with the given preferences.
        /// </summary>
        [JsonProperty("preferences")]
        [STJS.JsonPropertyName("preferences")]
        public PersonalizationDesignPreferencesOptions Preferences { get; set; }

        /// <summary>
        /// Only return personalization designs with the given status.
        /// One of: <c>active</c>, <c>inactive</c>, <c>rejected</c>, or <c>review</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
