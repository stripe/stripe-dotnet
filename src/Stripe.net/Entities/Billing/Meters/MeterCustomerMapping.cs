// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class MeterCustomerMapping : StripeEntity<MeterCustomerMapping>
    {
        /// <summary>
        /// The key in the meter event payload to use for mapping the event to a customer.
        /// </summary>
        [JsonProperty("event_payload_key")]
        [STJS.JsonPropertyName("event_payload_key")]
        public string EventPayloadKey { get; set; }

        /// <summary>
        /// The method for mapping a meter event to a customer.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
