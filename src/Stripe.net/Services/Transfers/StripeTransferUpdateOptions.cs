namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class StripeTransferUpdateOptions : StripeBaseOptions, ISupportMetadata
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
