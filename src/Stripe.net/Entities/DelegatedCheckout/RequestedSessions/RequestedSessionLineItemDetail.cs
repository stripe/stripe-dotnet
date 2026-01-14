// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RequestedSessionLineItemDetail : StripeEntity<RequestedSessionLineItemDetail>
    {
        /// <summary>
        /// The total discount for this line item. If no discount were applied, defaults to 0.
        /// </summary>
        [JsonProperty("amount_discount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_discount")]
#endif
        public long AmountDiscount { get; set; }

        /// <summary>
        /// The total before any discounts or taxes are applied.
        /// </summary>
        [JsonProperty("amount_subtotal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_subtotal")]
#endif
        public long AmountSubtotal { get; set; }

        /// <summary>
        /// The key of the line item.
        /// </summary>
        [JsonProperty("key")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("key")]
#endif
        public string Key { get; set; }

        [JsonProperty("product_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("product_details")]
#endif
        public RequestedSessionLineItemDetailProductDetails ProductDetails { get; set; }

        /// <summary>
        /// The quantity of the line item.
        /// </summary>
        [JsonProperty("quantity")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("quantity")]
#endif
        public long Quantity { get; set; }

        /// <summary>
        /// The SKU ID of the line item.
        /// </summary>
        [JsonProperty("sku_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sku_id")]
#endif
        public string SkuId { get; set; }

        /// <summary>
        /// The per-unit amount of the item before any discounts or taxes are applied.
        /// </summary>
        [JsonProperty("unit_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("unit_amount")]
#endif
        public long UnitAmount { get; set; }
    }
}
