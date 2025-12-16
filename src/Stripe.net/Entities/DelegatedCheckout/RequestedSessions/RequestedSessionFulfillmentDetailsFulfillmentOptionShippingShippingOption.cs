// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RequestedSessionFulfillmentDetailsFulfillmentOptionShippingShippingOption : StripeEntity<RequestedSessionFulfillmentDetailsFulfillmentOptionShippingShippingOption>
    {
        /// <summary>
        /// The description of the shipping option.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// The display name of the shipping option.
        /// </summary>
        [JsonProperty("display_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("display_name")]
#endif
        public string DisplayName { get; set; }

        /// <summary>
        /// The earliest delivery time of the shipping option.
        /// </summary>
        [JsonProperty("earliest_delivery_time")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("earliest_delivery_time")]
#endif
        public long? EarliestDeliveryTime { get; set; }

        /// <summary>
        /// The key of the shipping option.
        /// </summary>
        [JsonProperty("key")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("key")]
#endif
        public string Key { get; set; }

        /// <summary>
        /// The latest delivery time of the shipping option.
        /// </summary>
        [JsonProperty("latest_delivery_time")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("latest_delivery_time")]
#endif
        public long? LatestDeliveryTime { get; set; }

        /// <summary>
        /// The shipping amount of the shipping option.
        /// </summary>
        [JsonProperty("shipping_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping_amount")]
#endif
        public long ShippingAmount { get; set; }
    }
}
