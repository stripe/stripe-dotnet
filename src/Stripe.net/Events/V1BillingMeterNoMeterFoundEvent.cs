// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// This event occurs when async usage events have missing or invalid meter ids.
    /// </summary>
    public class V1BillingMeterNoMeterFoundEvent : V2.Event
    {
        /// <summary>
        /// Data for the v1.billing.meter.no_meter_found event.
        /// </summary>
        [JsonProperty("data")]

#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("data")]
#endif

        public V1BillingMeterNoMeterFoundEventData Data { get; set; }
    }
}
