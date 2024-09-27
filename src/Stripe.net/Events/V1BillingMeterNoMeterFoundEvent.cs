// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    /// <summary>
    /// This event occurs when an async usage event is missing a meter.
    /// </summary>
    public class V1BillingMeterNoMeterFoundEvent : V2.Event
    {
        /// <summary>
        /// Data for the v1.billing.meter.no_meter_found event.
        /// </summary>
        [JsonProperty("data")]

        public V1BillingMeterNoMeterFoundEventData Data { get; set; }
    }
}
