namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class InvoiceThresholdReasonItemReason : StripeEntity<InvoiceThresholdReasonItemReason>
    {
        [JsonProperty("line_item_ids")]
        public List<string> LineItemIds { get; set; }

        [JsonProperty("usage_gte")]
        public long UsageGte { get; set; }
    }
}
