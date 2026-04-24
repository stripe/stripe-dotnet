// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OffSessionPaymentCreateAmountDetailsLineItemOptions : INestedOptions
    {
        /// <summary>
        /// The amount an item was discounted for. Positive integer.
        /// </summary>
        [JsonProperty("discount_amount")]
        [STJS.JsonPropertyName("discount_amount")]
        public long? DiscountAmount { get; set; }

        /// <summary>
        /// Unique identifier of the product. At most 12 characters long.
        /// </summary>
        [JsonProperty("product_code")]
        [STJS.JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// Name of the product. At most 100 characters long.
        /// </summary>
        [JsonProperty("product_name")]
        [STJS.JsonPropertyName("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// Number of items of the product. Positive integer.
        /// </summary>
        [JsonProperty("quantity")]
        [STJS.JsonPropertyName("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// Contains information about the tax on the item.
        /// </summary>
        [JsonProperty("tax")]
        [STJS.JsonPropertyName("tax")]
        public OffSessionPaymentCreateAmountDetailsLineItemTaxOptions Tax { get; set; }

        /// <summary>
        /// Cost of the product. Positive integer.
        /// </summary>
        [JsonProperty("unit_cost")]
        [STJS.JsonPropertyName("unit_cost")]
        public long? UnitCost { get; set; }

        /// <summary>
        /// A unit of measure for the line item, such as gallons, feet, meters, etc. The maximum
        /// length is 12 characters.
        /// </summary>
        [JsonProperty("unit_of_measure")]
        [STJS.JsonPropertyName("unit_of_measure")]
        public string UnitOfMeasure { get; set; }
    }
}
