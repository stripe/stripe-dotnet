// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceLineItemParentSubscriptionItemDetails : StripeEntity<InvoiceLineItemParentSubscriptionItemDetails>
    {
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
        public InvoiceLineItemParentSubscriptionItemDetailsProrationDetails ProrationDetails { get; set; }

        [JsonProperty("subscription")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription")]
#endif
        public string Subscription { get; set; }

        [JsonProperty("subscription_item")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_item")]
#endif
        public string SubscriptionItem { get; set; }
    }
}
