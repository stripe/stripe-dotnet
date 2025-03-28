// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentLinkOptionalItemOptions : INestedOptions
    {
        /// <summary>
        /// When set, provides configuration for the customer to adjust the quantity of the line
        /// item created when a customer chooses to add this optional item to their order.
        /// </summary>
        [JsonProperty("adjustable_quantity")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("adjustable_quantity")]
#endif
        public PaymentLinkOptionalItemAdjustableQuantityOptions AdjustableQuantity { get; set; }

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
        /// The initial quantity of the line item created when a customer chooses to add this
        /// optional item to their order.
        /// </summary>
        [JsonProperty("quantity")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("quantity")]
#endif
        public long? Quantity { get; set; }
    }
}
