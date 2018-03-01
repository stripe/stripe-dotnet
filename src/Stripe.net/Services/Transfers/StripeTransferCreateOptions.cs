using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeTransferCreateOptions : StripeBaseOptions, ISupportMetadata
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("source_transaction")]
        public string SourceTransaction { get; set; }

        [JsonProperty("transfer_group")]
        public string TransferGroup { get; set; }

        [JsonProperty("source_type")]
        public string SourceType { get; set; }
    }
}
