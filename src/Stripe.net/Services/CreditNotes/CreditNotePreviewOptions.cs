namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CreditNotePreviewOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        [JsonProperty("credit_amount")]
        public long? CreditAmount { get; set; }

        [JsonProperty("invoice")]
        public string Invoice { get; set; }

        [JsonProperty("lines")]
        public List<CreditNoteLineOptions> Lines { get; set; }

        [JsonProperty("memo")]
        public string Memo { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("out_of_band_amount")]
        public long? OutOfBandAmount { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("refund")]
        public string Refund { get; set; }

        [JsonProperty("refund_amount")]
        public long? RefundAmount { get; set; }
    }
}
