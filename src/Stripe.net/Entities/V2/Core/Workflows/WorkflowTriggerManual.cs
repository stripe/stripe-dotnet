// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class WorkflowTriggerManual : StripeEntity<WorkflowTriggerManual>
    {
        /// <summary>
        /// An unprocessed version of the trigger's input parameter schema.
        /// </summary>
        [JsonProperty("raw_schema")]
        [STJS.JsonPropertyName("raw_schema")]
        public string RawSchema { get; set; }
    }
}
