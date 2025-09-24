// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OffSessionPaymentAmountDetailsLineItem : StripeEntity<OffSessionPaymentAmountDetailsLineItem>
    {
        /// <summary>
        /// The amount an item was discounted for. Positive integer.
        /// </summary>
        [JsonProperty("discount_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discount_amount")]
#endif
        public long DiscountAmount { get; set; }

        /// <summary>
        /// Unique identifier of the product. At most 12 characters long.
        /// </summary>
        [JsonProperty("product_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("product_code")]
#endif
        public string ProductCode { get; set; }

        /// <summary>
        /// Name of the product. At most 100 characters long.
        /// </summary>
        [JsonProperty("product_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("product_name")]
#endif
        public string ProductName { get; set; }

        /// <summary>
        /// Number of items of the product. Positive integer.
        /// </summary>
        [JsonProperty("quantity")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("quantity")]
#endif
        public long Quantity { get; set; }

        /// <summary>
        /// Contains information about the tax on the item.
        /// </summary>
        [JsonProperty("tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax")]
#endif
        public OffSessionPaymentAmountDetailsLineItemTax Tax { get; set; }

        /// <summary>
        /// Cost of the product. Non-negative integer.
        /// </summary>
        [JsonProperty("unit_cost")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("unit_cost")]
#endif
        public long UnitCost { get; set; }
    }
}
