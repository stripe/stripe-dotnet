// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when a Meter's id is missing or invalid in async usage events.
    /// </summary>
    public class V1BillingMeterNoMeterFoundEvent : V2.Core.Event
    {
        /// <summary>
        /// Data for the v1.billing.meter.no_meter_found event.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]

        public V1BillingMeterNoMeterFoundEventData Data { get; set; }
    }
}
