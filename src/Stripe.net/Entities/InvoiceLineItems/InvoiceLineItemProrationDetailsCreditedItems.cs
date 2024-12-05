// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceLineItemProrationDetailsCreditedItems : StripeEntity<InvoiceLineItemProrationDetailsCreditedItems>
    {
        /// <summary>
        /// Invoice containing the credited invoice line items.
        /// </summary>
        [JsonProperty("invoice")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice")]
#endif
        public string Invoice { get; set; }

        /// <summary>
        /// Credited invoice line items.
        /// </summary>
        [JsonProperty("invoice_line_items")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice_line_items")]
#endif
        public List<string> InvoiceLineItems { get; set; }
    }
}
