// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoiceLineItemParentScheduleDetails : StripeEntity<InvoiceLineItemParentScheduleDetails>
    {
        /// <summary>
        /// The invoice item that generated this line item.
        /// </summary>
        [JsonProperty("invoice_item")]
        [STJS.JsonPropertyName("invoice_item")]
        public string InvoiceItem { get; set; }

        /// <summary>
        /// Whether this is a proration.
        /// </summary>
        [JsonProperty("proration")]
        [STJS.JsonPropertyName("proration")]
        public bool Proration { get; set; }

        /// <summary>
        /// Additional details for proration line items.
        /// </summary>
        [JsonProperty("proration_details")]
        [STJS.JsonPropertyName("proration_details")]
        public InvoiceLineItemParentScheduleDetailsProrationDetails ProrationDetails { get; set; }

        /// <summary>
        /// The subscription schedule that generated this line item.
        /// </summary>
        [JsonProperty("schedule")]
        [STJS.JsonPropertyName("schedule")]
        public string Schedule { get; set; }

        /// <summary>
        /// The subscription that the schedule belongs to.
        /// </summary>
        [JsonProperty("subscription")]
        [STJS.JsonPropertyName("subscription")]
        public string Subscription { get; set; }
    }
}
