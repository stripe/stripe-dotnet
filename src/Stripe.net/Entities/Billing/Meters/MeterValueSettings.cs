// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;

    public class MeterValueSettings : StripeEntity<MeterValueSettings>
    {
        /// <summary>
        /// The key in the usage event payload to use as the value for this meter.
        /// </summary>
        [JsonProperty("event_payload_key")]
        public string EventPayloadKey { get; set; }
    }
}
