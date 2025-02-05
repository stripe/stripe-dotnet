// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;

    public class AlertListOptions : ListOptions
    {
        /// <summary>
        /// Filter results to only include this type of alert.
        /// </summary>
        [JsonProperty("alert_type")]
        public string AlertType { get; set; }

        /// <summary>
        /// Filter results to only include alerts with the given meter.
        /// </summary>
        [JsonProperty("meter")]
        public string Meter { get; set; }
    }
}
