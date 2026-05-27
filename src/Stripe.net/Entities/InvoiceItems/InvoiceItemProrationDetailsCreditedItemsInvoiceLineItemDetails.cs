// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoiceItemProrationDetailsCreditedItemsInvoiceLineItemDetails : StripeEntity<InvoiceItemProrationDetailsCreditedItemsInvoiceLineItemDetails>
    {
        /// <summary>
        /// The invoice id for the debited line item(s).
        /// </summary>
        [JsonProperty("invoice")]
        [STJS.JsonPropertyName("invoice")]
        public string Invoice { get; set; }

        /// <summary>
        /// IDs of the debited invoice line item(s) on the invoice that correspond to the credit
        /// proration.
        /// </summary>
        [JsonProperty("invoice_line_items")]
        [STJS.JsonPropertyName("invoice_line_items")]
        public List<string> InvoiceLineItems { get; set; }
    }
}
