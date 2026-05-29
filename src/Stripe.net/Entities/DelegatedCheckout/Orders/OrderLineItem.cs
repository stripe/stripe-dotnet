// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OrderLineItem : StripeEntity<OrderLineItem>
    {
        /// <summary>
        /// The order line item key.
        /// </summary>
        [JsonProperty("key")]
        [STJS.JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonProperty("product_details")]
        [STJS.JsonPropertyName("product_details")]
        public OrderLineItemProductDetails ProductDetails { get; set; }

        [JsonProperty("quantity")]
        [STJS.JsonPropertyName("quantity")]
        public OrderLineItemQuantity Quantity { get; set; }

        /// <summary>
        /// The SKU ID of the line item.
        /// </summary>
        [JsonProperty("sku_id")]
        [STJS.JsonPropertyName("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// The totals for this line item.
        /// </summary>
        [JsonProperty("totals")]
        [STJS.JsonPropertyName("totals")]
        public OrderLineItemTotals Totals { get; set; }

        /// <summary>
        /// The line item unit amount.
        /// </summary>
        [JsonProperty("unit_amount")]
        [STJS.JsonPropertyName("unit_amount")]
        public long UnitAmount { get; set; }
    }
}
