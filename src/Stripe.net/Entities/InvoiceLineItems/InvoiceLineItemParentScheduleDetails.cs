// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceLineItemParentScheduleDetails : StripeEntity<InvoiceLineItemParentScheduleDetails>
    {
        /// <summary>
        /// The subscription schedule that generated this line item.
        /// </summary>
        [JsonProperty("schedule")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("schedule")]
#endif
        public string Schedule { get; set; }

        /// <summary>
        /// The invoice item that generated this line item.
        /// </summary>
        [JsonProperty("invoice_item")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice_item")]
#endif
        public string InvoiceItem { get; set; }

        /// <summary>
        /// Whether this is a proration.
        /// </summary>
        [JsonProperty("proration")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("proration")]
#endif
        public bool Proration { get; set; }

        /// <summary>
        /// Additional details for proration line items.
        /// </summary>
        [JsonProperty("proration_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("proration_details")]
#endif
        public InvoiceLineItemParentScheduleDetailsProrationDetails ProrationDetails { get; set; }

        /// <summary>
        /// The subscription that the schedule belongs to.
        /// </summary>
        [JsonProperty("subscription")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription")]
#endif
        public string Subscription { get; set; }
    }
}
