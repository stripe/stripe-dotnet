// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceLineItemParent : StripeEntity<InvoiceLineItemParent>
    {
        [JsonProperty("invoice_item_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice_item_details")]
#endif
        public InvoiceLineItemParentInvoiceItemDetails InvoiceItemDetails { get; set; }

        [JsonProperty("subscription_item_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_item_details")]
#endif
        public InvoiceLineItemParentSubscriptionItemDetails SubscriptionItemDetails { get; set; }

        /// <summary>
        /// One of: <c>invoice_item_details</c>, or <c>subscription_item_details</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
