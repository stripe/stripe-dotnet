namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class InvoiceThresholdReasonItemReason : StripeEntity<InvoiceThresholdReasonItemReason>
    {
        /// <summary>
        /// The IDs of the line items that triggered the threshold invoice.
        /// </summary>
        [JsonProperty("line_item_ids")]
        public List<string> LineItemIds { get; set; }

        /// <summary>
        /// The quantity threshold boundary that applied to the given line item.
        /// </summary>
        [JsonProperty("usage_gte")]
        public long UsageGte { get; set; }
    }
}
