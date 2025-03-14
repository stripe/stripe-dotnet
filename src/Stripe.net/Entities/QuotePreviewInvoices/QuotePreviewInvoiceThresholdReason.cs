// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class QuotePreviewInvoiceThresholdReason : StripeEntity<QuotePreviewInvoiceThresholdReason>
    {
        /// <summary>
        /// The total invoice amount threshold boundary if it triggered the threshold invoice.
        /// </summary>
        [JsonProperty("amount_gte")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_gte")]
#endif
        public long? AmountGte { get; set; }

        /// <summary>
        /// Indicates which line items triggered a threshold invoice.
        /// </summary>
        [JsonProperty("item_reasons")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("item_reasons")]
#endif
        public List<QuotePreviewInvoiceThresholdReasonItemReason> ItemReasons { get; set; }
    }
}
