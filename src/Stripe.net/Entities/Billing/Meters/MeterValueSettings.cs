// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class MeterValueSettings : StripeEntity<MeterValueSettings>
    {
        /// <summary>
        /// The key in the meter event payload to use as the value for this meter.
        /// </summary>
        [JsonProperty("event_payload_key")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("event_payload_key")]
#endif

        public string EventPayloadKey { get; set; }
    }
}
