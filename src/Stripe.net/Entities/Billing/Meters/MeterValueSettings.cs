// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class MeterValueSettings : StripeEntity<MeterValueSettings>
    {
        /// <summary>
        /// The key in the meter event payload to use as the value for this meter.
        /// </summary>
        [JsonProperty("event_payload_key")]
        [STJS.JsonPropertyName("event_payload_key")]
        public string EventPayloadKey { get; set; }
    }
}
