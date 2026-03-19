// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoiceLineItemParentSubscriptionItemDetails : StripeEntity<InvoiceLineItemParentSubscriptionItemDetails>
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
        public InvoiceLineItemParentSubscriptionItemDetailsProrationDetails ProrationDetails { get; set; }

        /// <summary>
        /// The subscription that the subscription item belongs to.
        /// </summary>
        [JsonProperty("subscription")]
        [STJS.JsonPropertyName("subscription")]
        public string Subscription { get; set; }

        /// <summary>
        /// The subscription item that generated this line item.
        /// </summary>
        [JsonProperty("subscription_item")]
        [STJS.JsonPropertyName("subscription_item")]
        public string SubscriptionItem { get; set; }
    }
}
