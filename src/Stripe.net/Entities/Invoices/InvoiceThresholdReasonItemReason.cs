// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceThresholdReasonItemReason : StripeEntity<InvoiceThresholdReasonItemReason>
    {
        /// <summary>
        /// The IDs of the line items that triggered the threshold invoice.
        /// </summary>
        [JsonProperty("line_item_ids")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("line_item_ids")]
#endif

        public List<string> LineItemIds { get; set; }

        /// <summary>
        /// The quantity threshold boundary that applied to the given line item.
        /// </summary>
        [JsonProperty("usage_gte")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("usage_gte")]
#endif

        public long UsageGte { get; set; }
    }
}
