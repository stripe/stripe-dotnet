// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RequestedSessionLineItemDetail : StripeEntity<RequestedSessionLineItemDetail>
    {
        /// <summary>
        /// The total discount for this line item. If no discount were applied, defaults to 0.
        /// </summary>
        [JsonProperty("amount_discount")]
        [STJS.JsonPropertyName("amount_discount")]
        public long AmountDiscount { get; set; }

        /// <summary>
        /// The total before any discounts or taxes are applied.
        /// </summary>
        [JsonProperty("amount_subtotal")]
        [STJS.JsonPropertyName("amount_subtotal")]
        public long AmountSubtotal { get; set; }

        /// <summary>
        /// The key of the line item.
        /// </summary>
        [JsonProperty("key")]
        [STJS.JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonProperty("product_details")]
        [STJS.JsonPropertyName("product_details")]
        public RequestedSessionLineItemDetailProductDetails ProductDetails { get; set; }

        /// <summary>
        /// The quantity of the line item.
        /// </summary>
        [JsonProperty("quantity")]
        [STJS.JsonPropertyName("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// The SKU ID of the line item.
        /// </summary>
        [JsonProperty("sku_id")]
        [STJS.JsonPropertyName("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// The per-unit amount of the item before any discounts or taxes are applied.
        /// </summary>
        [JsonProperty("unit_amount")]
        [STJS.JsonPropertyName("unit_amount")]
        public long UnitAmount { get; set; }

        /// <summary>
        /// The fulfillment type of the line item.
        /// </summary>
        [JsonProperty("fulfillment_type")]
        [STJS.JsonPropertyName("fulfillment_type")]
        public string FulfillmentType { get; set; }
    }
}
