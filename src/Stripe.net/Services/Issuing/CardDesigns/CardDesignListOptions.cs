// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CardDesignListOptions : ListOptions
    {
        [JsonProperty("lookup_keys")]
        public List<string> LookupKeys { get; set; }

        [JsonProperty("preferences")]
        public CardDesignPreferencesOptions Preferences { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
