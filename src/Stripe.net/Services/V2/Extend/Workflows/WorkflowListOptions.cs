// File generated from our OpenAPI spec
namespace Stripe.V2.Extend
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class WorkflowListOptions : V2.ListOptions
    {
        /// <summary>
        /// When retrieving Workflows, include only those with the specified status values. If not
        /// specified, all Workflows in active and inactive status are returned.
        /// One of: <c>active</c>, <c>archived</c>, <c>draft</c>, or <c>inactive</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public List<string> Status { get; set; }
    }
}
