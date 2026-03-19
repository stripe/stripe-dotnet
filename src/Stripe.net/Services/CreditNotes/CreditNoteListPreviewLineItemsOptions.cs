namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class CreditNoteListPreviewLineItemsOptions : ListOptions, IHasMetadata
    {
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long? Amount { get; set; }

        [JsonProperty("credit_amount")]
        [STJS.JsonPropertyName("credit_amount")]
        public long? CreditAmount { get; set; }

        [JsonProperty("invoice")]
        [STJS.JsonPropertyName("invoice")]
        public string Invoice { get; set; }

        [JsonProperty("memo")]
        [STJS.JsonPropertyName("memo")]
        public string Memo { get; set; }

        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("out_of_band_amount")]
        [STJS.JsonPropertyName("out_of_band_amount")]
        public long? OutOfBandAmount { get; set; }

        [JsonProperty("reason")]
        [STJS.JsonPropertyName("reason")]
        public string Reason { get; set; }

        [JsonProperty("refund")]
        [STJS.JsonPropertyName("refund")]
        public string Refund { get; set; }

        [JsonProperty("refund_amount")]
        [STJS.JsonPropertyName("refund_amount")]
        public long? RefundAmount { get; set; }
    }
}
