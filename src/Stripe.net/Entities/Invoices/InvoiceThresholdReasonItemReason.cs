// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoiceThresholdReasonItemReason : StripeEntity<InvoiceThresholdReasonItemReason>
    {
        /// <summary>
        /// The IDs of the line items that triggered the threshold invoice.
        /// </summary>
        [JsonProperty("line_item_ids")]
        [STJS.JsonPropertyName("line_item_ids")]
        public List<string> LineItemIds { get; set; }

        /// <summary>
        /// The quantity threshold boundary that applied to the given line item.
        /// </summary>
        [JsonProperty("usage_gte")]
        [STJS.JsonPropertyName("usage_gte")]
        public long UsageGte { get; set; }
    }
}
