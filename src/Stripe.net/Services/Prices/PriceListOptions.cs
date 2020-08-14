namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PriceListOptions : ListOptionsWithCreated
    {
        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("lookup_keys")]
        public List<string> LookupKeys { get; set; }

        [JsonProperty("product")]
        public string Product { get; set; }

        [JsonProperty("recurring")]
        public PriceRecurringListOptions Recurring { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
