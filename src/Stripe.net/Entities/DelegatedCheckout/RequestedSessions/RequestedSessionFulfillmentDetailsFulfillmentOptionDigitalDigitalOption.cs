// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RequestedSessionFulfillmentDetailsFulfillmentOptionDigitalDigitalOption : StripeEntity<RequestedSessionFulfillmentDetailsFulfillmentOptionDigitalDigitalOption>
    {
        /// <summary>
        /// The description of the digital fulfillment option.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// The digital amount of the digital fulfillment option.
        /// </summary>
        [JsonProperty("digital_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("digital_amount")]
#endif
        public long DigitalAmount { get; set; }

        /// <summary>
        /// The display name of the digital fulfillment option.
        /// </summary>
        [JsonProperty("display_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("display_name")]
#endif
        public string DisplayName { get; set; }

        /// <summary>
        /// The key of the digital fulfillment option.
        /// </summary>
        [JsonProperty("key")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("key")]
#endif
        public string Key { get; set; }
    }
}
