// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceLineItemParentScheduleDetailsProrationDetails : StripeEntity<InvoiceLineItemParentScheduleDetailsProrationDetails>
    {
        /// <summary>
        /// For a credit proration <c>line_item</c>, the original debit line_items to which the
        /// credit proration applies.
        /// </summary>
        [JsonProperty("credited_items")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("credited_items")]
#endif
        public InvoiceLineItemParentScheduleDetailsProrationDetailsCreditedItems CreditedItems { get; set; }
    }
}
