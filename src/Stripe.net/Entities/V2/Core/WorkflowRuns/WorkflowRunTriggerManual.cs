// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class WorkflowRunTriggerManual : StripeEntity<WorkflowRunTriggerManual>
    {
        /// <summary>
        /// The input parameters used when launching the Run.
        /// </summary>
        [JsonProperty("input_parameters")]
        [STJS.JsonPropertyName("input_parameters")]
        public Dictionary<string, object> InputParameters { get; set; }
    }
}
