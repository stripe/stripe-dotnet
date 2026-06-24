// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Health
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AlertInvoiceCountDropped : StripeEntity<AlertInvoiceCountDropped>
    {
        /// <summary>
        /// The observed number of invoices within the time window.
        /// </summary>
        [JsonProperty("observed_count")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("observed_count")]
        public decimal ObservedCount { get; set; }

        /// <summary>
        /// The expected threshold number of invoices within the time window.
        /// </summary>
        [JsonProperty("threshold_count")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("threshold_count")]
        public decimal ThresholdCount { get; set; }

        /// <summary>
        /// The size of the observation time window.
        /// </summary>
        [JsonProperty("time_window")]
        [STJS.JsonPropertyName("time_window")]
        public string TimeWindow { get; set; }
    }
}
