// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoiceItemProrationDetailsCreditedItems : StripeEntity<InvoiceItemProrationDetailsCreditedItems>
    {
        /// <summary>
        /// When <c>type</c> is <c>invoice_item</c>, the invoice item id for the debited invoice
        /// item corresponding to this credit proration.
        /// </summary>
        [JsonProperty("invoice_item")]
        [STJS.JsonPropertyName("invoice_item")]
        public string InvoiceItem { get; set; }

        [JsonProperty("invoice_line_items")]
        [STJS.JsonPropertyName("invoice_line_items")]
        public InvoiceItemProrationDetailsCreditedItemsInvoiceLineItems InvoiceLineItems { get; set; }

        /// <summary>
        /// Whether the credit references a pending invoice item or one or more invoice line items
        /// on an invoice.
        /// One of: <c>invoice_item</c>, or <c>invoice_line_items</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
