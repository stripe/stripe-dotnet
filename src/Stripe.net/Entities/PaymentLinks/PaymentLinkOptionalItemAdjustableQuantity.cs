// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentLinkOptionalItemAdjustableQuantity : StripeEntity<PaymentLinkOptionalItemAdjustableQuantity>
    {
        /// <summary>
        /// Set to true if the quantity can be adjusted to any non-negative integer.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// The maximum quantity of this item the customer can purchase. By default this value is
        /// 99.
        /// </summary>
        [JsonProperty("maximum")]
        [STJS.JsonPropertyName("maximum")]
        public long? Maximum { get; set; }

        /// <summary>
        /// The minimum quantity of this item the customer must purchase, if they choose to purchase
        /// it. Because this item is optional, the customer will always be able to remove it from
        /// their order, even if the <c>minimum</c> configured here is greater than 0. By default
        /// this value is 0.
        /// </summary>
        [JsonProperty("minimum")]
        [STJS.JsonPropertyName("minimum")]
        public long? Minimum { get; set; }
    }
}
