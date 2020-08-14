namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class TopupCreateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("transfer_group")]
        public string TransferGroup { get; set; }
    }
}
