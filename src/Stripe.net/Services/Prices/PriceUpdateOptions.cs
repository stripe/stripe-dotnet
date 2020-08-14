namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PriceUpdateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("lookup_key")]
        public string LookupKey { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("recurring")]
        public PriceRecurringOptions Recurring { get; set; }

        [JsonProperty("transfer_lookup_key")]
        public bool? TransferLookupKey { get; set; }
    }
}
