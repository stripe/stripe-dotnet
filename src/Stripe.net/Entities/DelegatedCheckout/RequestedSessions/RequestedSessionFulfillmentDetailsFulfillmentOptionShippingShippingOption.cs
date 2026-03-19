// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RequestedSessionFulfillmentDetailsFulfillmentOptionShippingShippingOption : StripeEntity<RequestedSessionFulfillmentDetailsFulfillmentOptionShippingShippingOption>
    {
        /// <summary>
        /// The description of the shipping option.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The display name of the shipping option.
        /// </summary>
        [JsonProperty("display_name")]
        [STJS.JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// The earliest delivery time of the shipping option.
        /// </summary>
        [JsonProperty("earliest_delivery_time")]
        [STJS.JsonPropertyName("earliest_delivery_time")]
        public long? EarliestDeliveryTime { get; set; }

        /// <summary>
        /// The key of the shipping option.
        /// </summary>
        [JsonProperty("key")]
        [STJS.JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// The latest delivery time of the shipping option.
        /// </summary>
        [JsonProperty("latest_delivery_time")]
        [STJS.JsonPropertyName("latest_delivery_time")]
        public long? LatestDeliveryTime { get; set; }

        /// <summary>
        /// The shipping amount of the shipping option.
        /// </summary>
        [JsonProperty("shipping_amount")]
        [STJS.JsonPropertyName("shipping_amount")]
        public long ShippingAmount { get; set; }
    }
}
