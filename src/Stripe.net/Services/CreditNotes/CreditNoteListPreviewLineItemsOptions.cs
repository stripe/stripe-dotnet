namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    using Stripe.Infrastructure;

    public class CreditNoteListPreviewLineItemsOptions : ListOptions, IHasMetadata
    {
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long? Amount { get; set; }

        [JsonProperty("credit_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("credit_amount")]
#endif
        public long? CreditAmount { get; set; }

        [JsonProperty("invoice")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice")]
#endif
        public string Invoice { get; set; }

        [JsonProperty("memo")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("memo")]
#endif
        public string Memo { get; set; }

        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("out_of_band_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("out_of_band_amount")]
#endif
        public long? OutOfBandAmount { get; set; }

        [JsonProperty("reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reason")]
#endif
        public string Reason { get; set; }

        [JsonProperty("refund")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("refund")]
#endif
        public string Refund { get; set; }

        [JsonProperty("refund_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("refund_amount")]
#endif
        public long? RefundAmount { get; set; }
    }
}
