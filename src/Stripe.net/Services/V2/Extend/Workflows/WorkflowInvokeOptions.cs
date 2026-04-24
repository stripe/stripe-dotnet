// File generated from our OpenAPI spec
namespace Stripe.V2.Extend
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class WorkflowInvokeOptions : BaseOptions
    {
        /// <summary>
        /// Parameters used to invoke the Workflow Run.
        /// </summary>
        [JsonProperty("input_parameters")]
        [STJS.JsonPropertyName("input_parameters")]
        public Dictionary<string, object> InputParameters { get; set; }
    }
}
