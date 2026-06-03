// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OrderEventAdjustmentLineItem : StripeEntity<OrderEventAdjustmentLineItem>
    {
        /// <summary>
        /// The line item key.
        /// </summary>
        [JsonProperty("key")]
        [STJS.JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// The quantity associated with the order event.
        /// </summary>
        [JsonProperty("quantity")]
        [STJS.JsonPropertyName("quantity")]
        public long Quantity { get; set; }
    }
}
