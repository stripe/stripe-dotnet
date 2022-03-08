// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class InvoiceLineItemProrationDetailsCreditedItems : StripeEntity<InvoiceLineItemProrationDetailsCreditedItems>
    {
        /// <summary>
        /// Invoice containing the credited invoice line items.
        /// </summary>
        [JsonProperty("invoice")]
        public string Invoice { get; set; }

        /// <summary>
        /// Credited invoice line items.
        /// </summary>
        [JsonProperty("invoice_line_items")]
        public List<string> InvoiceLineItems { get; set; }
    }
}
