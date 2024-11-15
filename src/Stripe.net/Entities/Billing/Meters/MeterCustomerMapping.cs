// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class MeterCustomerMapping : StripeEntity<MeterCustomerMapping>
    {
        /// <summary>
        /// The key in the meter event payload to use for mapping the event to a customer.
        /// </summary>
        [JsonProperty("event_payload_key")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("event_payload_key")]
#endif

        public string EventPayloadKey { get; set; }

        /// <summary>
        /// The method for mapping a meter event to a customer.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif

        public string Type { get; set; }
    }
}
