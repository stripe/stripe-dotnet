// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentAmountDetailsLineItem : StripeEntity<PaymentIntentAmountDetailsLineItem>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// The discount applied on this line item represented in the <a
        /// href="https://docs.stripe.com/currencies#zero-decimal">smallest currency unit</a>. An
        /// integer greater than 0.
        ///
        /// This field is mutually exclusive with the <c>amount_details[discount_amount]</c> field.
        /// </summary>
        [JsonProperty("discount_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discount_amount")]
#endif
        public long? DiscountAmount { get; set; }

        /// <summary>
        /// Payment method-specific information for line items.
        /// </summary>
        [JsonProperty("payment_method_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_options")]
#endif
        public PaymentIntentAmountDetailsLineItemPaymentMethodOptions PaymentMethodOptions { get; set; }

        /// <summary>
        /// The product code of the line item, such as an SKU. Required for L3 rates. At most 12
        /// characters long.
        /// </summary>
        [JsonProperty("product_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("product_code")]
#endif
        public string ProductCode { get; set; }

        /// <summary>
        /// The product name of the line item. Required for L3 rates. At most 1024 characters long.
        ///
        /// For Cards, this field is truncated to 26 alphanumeric characters before being sent to
        /// the card networks. For Paypal, this field is truncated to 127 characters.
        /// </summary>
        [JsonProperty("product_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("product_name")]
#endif
        public string ProductName { get; set; }

        /// <summary>
        /// The quantity of items. Required for L3 rates. An integer greater than 0.
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
        public PaymentIntentAmountDetailsLineItemTax Tax { get; set; }

        /// <summary>
        /// The unit cost of the line item represented in the <a
        /// href="https://docs.stripe.com/currencies#zero-decimal">smallest currency unit</a>.
        /// Required for L3 rates. An integer greater than or equal to 0.
        /// </summary>
        [JsonProperty("unit_cost")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("unit_cost")]
#endif
        public long UnitCost { get; set; }

        /// <summary>
        /// A unit of measure for the line item, such as gallons, feet, meters, etc. Required for L3
        /// rates. At most 12 alphanumeric characters long.
        /// </summary>
        [JsonProperty("unit_of_measure")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("unit_of_measure")]
#endif
        public string UnitOfMeasure { get; set; }
    }
}
