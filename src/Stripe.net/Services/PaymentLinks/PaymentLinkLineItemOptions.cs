// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentLinkLineItemOptions : INestedOptions, IHasId
    {
        /// <summary>
        /// When set, provides configuration for this item’s quantity to be adjusted by the customer
        /// during checkout.
        /// </summary>
        [JsonProperty("adjustable_quantity")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("adjustable_quantity")]
#endif
        public PaymentLinkLineItemAdjustableQuantityOptions AdjustableQuantity { get; set; }

        /// <summary>
        /// The ID of an existing line item on the payment link.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// The ID of the <a href="https://stripe.com/docs/api/prices">Price</a> or <a
        /// href="https://stripe.com/docs/api/plans">Plan</a> object.
        /// </summary>
        [JsonProperty("price")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("price")]
#endif
        public string Price { get; set; }

        /// <summary>
        /// Data used to generate a new <a href="https://stripe.com/docs/api/prices">Price</a>
        /// object inline. One of <c>price</c> or <c>price_data</c> is required.
        /// </summary>
        [JsonProperty("price_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("price_data")]
#endif
        public PaymentLinkLineItemPriceDataOptions PriceData { get; set; }

        /// <summary>
        /// The quantity of the line item being purchased.
        /// </summary>
        [JsonProperty("quantity")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("quantity")]
#endif
        public long? Quantity { get; set; }
    }
}
