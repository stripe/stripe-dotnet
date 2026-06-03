// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OrderLineItemQuantity : StripeEntity<OrderLineItemQuantity>
    {
        /// <summary>
        /// The current quantity.
        /// </summary>
        [JsonProperty("current")]
        [STJS.JsonPropertyName("current")]
        public long Current { get; set; }

        /// <summary>
        /// The ordered quantity.
        /// </summary>
        [JsonProperty("ordered")]
        [STJS.JsonPropertyName("ordered")]
        public long Ordered { get; set; }

        /// <summary>
        /// The shipped quantity.
        /// </summary>
        [JsonProperty("shipped")]
        [STJS.JsonPropertyName("shipped")]
        public long Shipped { get; set; }
    }
}
