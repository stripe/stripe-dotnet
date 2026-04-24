// File generated from our OpenAPI spec
namespace Stripe.V2.Extend
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class WorkflowRunListOptions : V2.ListOptions
    {
        /// <summary>
        /// When retrieving Workflow Runs, include only those with the specified status values. If
        /// not specified, all Runs are returned.
        /// One of: <c>failed</c>, <c>started</c>, or <c>succeeded</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public List<string> Status { get; set; }

        /// <summary>
        /// When retrieving Workflow Runs, include only those associated with the Workflows
        /// specified. If not specified, all Runs are returned.
        /// </summary>
        [JsonProperty("workflow")]
        [STJS.JsonPropertyName("workflow")]
        public List<string> Workflow { get; set; }
    }
}
