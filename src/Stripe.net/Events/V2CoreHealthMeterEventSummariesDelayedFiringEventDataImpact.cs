// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2CoreHealthMeterEventSummariesDelayedFiringEventDataImpact : StripeEntity<V2CoreHealthMeterEventSummariesDelayedFiringEventDataImpact>
    {
        /// <summary>
        /// The ingestion method.
        /// </summary>
        [JsonProperty("ingestion_method")]
        [STJS.JsonPropertyName("ingestion_method")]
        public string IngestionMethod { get; set; }
    }
}
