// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoiceLineItemParent : StripeEntity<InvoiceLineItemParent>
    {
        /// <summary>
        /// Details about the invoice item that generated this line item.
        /// </summary>
        [JsonProperty("invoice_item_details")]
        [STJS.JsonPropertyName("invoice_item_details")]
        public InvoiceLineItemParentInvoiceItemDetails InvoiceItemDetails { get; set; }

        /// <summary>
        /// Details about the subscription item that generated this line item.
        /// </summary>
        [JsonProperty("subscription_item_details")]
        [STJS.JsonPropertyName("subscription_item_details")]
        public InvoiceLineItemParentSubscriptionItemDetails SubscriptionItemDetails { get; set; }

        /// <summary>
        /// The type of parent that generated this line item.
        /// One of: <c>invoice_item_details</c>, or <c>subscription_item_details</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
