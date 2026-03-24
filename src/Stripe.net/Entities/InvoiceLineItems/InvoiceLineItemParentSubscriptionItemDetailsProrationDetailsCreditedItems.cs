// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoiceLineItemParentSubscriptionItemDetailsProrationDetailsCreditedItems : StripeEntity<InvoiceLineItemParentSubscriptionItemDetailsProrationDetailsCreditedItems>
    {
        /// <summary>
        /// Invoice containing the credited invoice line items.
        /// </summary>
        [JsonProperty("invoice")]
        [STJS.JsonPropertyName("invoice")]
        public string Invoice { get; set; }

        /// <summary>
        /// Credited invoice line items.
        /// </summary>
        [JsonProperty("invoice_line_items")]
        [STJS.JsonPropertyName("invoice_line_items")]
        public List<string> InvoiceLineItems { get; set; }
    }
}
