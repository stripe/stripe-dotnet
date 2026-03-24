// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoiceLineItemParentInvoiceItemDetailsProrationDetails : StripeEntity<InvoiceLineItemParentInvoiceItemDetailsProrationDetails>
    {
        /// <summary>
        /// For a credit proration <c>line_item</c>, the original debit line_items to which the
        /// credit proration applies.
        /// </summary>
        [JsonProperty("credited_items")]
        [STJS.JsonPropertyName("credited_items")]
        public InvoiceLineItemParentInvoiceItemDetailsProrationDetailsCreditedItems CreditedItems { get; set; }
    }
}
