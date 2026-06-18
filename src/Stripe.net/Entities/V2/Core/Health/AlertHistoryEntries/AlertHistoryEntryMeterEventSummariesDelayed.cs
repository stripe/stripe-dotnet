// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Health
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AlertHistoryEntryMeterEventSummariesDelayed : StripeEntity<AlertHistoryEntryMeterEventSummariesDelayed>
    {
        /// <summary>
        /// The ingestion method.
        /// </summary>
        [JsonProperty("ingestion_method")]
        [STJS.JsonPropertyName("ingestion_method")]
        public string IngestionMethod { get; set; }
    }
}
