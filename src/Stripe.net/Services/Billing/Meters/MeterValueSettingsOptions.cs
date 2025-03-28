// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class MeterValueSettingsOptions : INestedOptions
    {
        /// <summary>
        /// The key in the usage event payload to use as the value for this meter. For example, if
        /// the event payload contains usage on a <c>bytes_used</c> field, then set the
        /// event_payload_key to "bytes_used".
        /// </summary>
        [JsonProperty("event_payload_key")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("event_payload_key")]
#endif
        public string EventPayloadKey { get; set; }
    }
}
