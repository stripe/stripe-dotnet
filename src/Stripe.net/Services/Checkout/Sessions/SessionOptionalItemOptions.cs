// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionOptionalItemOptions : INestedOptions
    {
        /// <summary>
        /// When set, provides configuration for the customer to adjust the quantity of the line
        /// item created when a customer chooses to add this optional item to their order.
        /// </summary>
        [JsonProperty("adjustable_quantity")]
        [STJS.JsonPropertyName("adjustable_quantity")]
        public SessionOptionalItemAdjustableQuantityOptions AdjustableQuantity { get; set; }

        /// <summary>
        /// The ID of the <a href="https://docs.stripe.com/api/prices">Price</a> or <a
        /// href="https://docs.stripe.com/api/plans">Plan</a> object.
        /// </summary>
        [JsonProperty("price")]
        [STJS.JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// The initial quantity of the line item created when a customer chooses to add this
        /// optional item to their order.
        /// </summary>
        [JsonProperty("quantity")]
        [STJS.JsonPropertyName("quantity")]
        public long? Quantity { get; set; }
    }
}
