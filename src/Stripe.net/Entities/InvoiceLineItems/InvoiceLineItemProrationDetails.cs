// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceLineItemProrationDetails : StripeEntity<InvoiceLineItemProrationDetails>
    {
        /// <summary>
        /// For a credit proration <c>line_item</c>, the original debit line_items to which the
        /// credit proration applies.
        /// </summary>
        [JsonProperty("credited_items")]
        public InvoiceLineItemProrationDetailsCreditedItems CreditedItems { get; set; }
    }
}
