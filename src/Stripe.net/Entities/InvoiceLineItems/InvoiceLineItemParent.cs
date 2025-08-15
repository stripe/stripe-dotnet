// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceLineItemParent : StripeEntity<InvoiceLineItemParent>
    {
        /// <summary>
        /// Details about the invoice item that generated this line item.
        /// </summary>
        [JsonProperty("invoice_item_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice_item_details")]
#endif
        public InvoiceLineItemParentInvoiceItemDetails InvoiceItemDetails { get; set; }

        /// <summary>
        /// Details about the subscription item that generated this line item.
        /// </summary>
        [JsonProperty("subscription_item_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_item_details")]
#endif
        public InvoiceLineItemParentSubscriptionItemDetails SubscriptionItemDetails { get; set; }

        /// <summary>
        /// The type of parent that generated this line item.
        /// One of: <c>invoice_item_details</c>, <c>subscription_item_details</c>, or
        /// <c>rate_card_subscription_details</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        [JsonProperty("rate_card_subscription_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rate_card_subscription_details")]
#endif
        public InvoiceLineItemParentRateCardSubscriptionDetails RateCardSubscriptionDetails { get; set; }
    }
}
