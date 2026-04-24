// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2ExtendWorkflowRunFailedEventData : StripeEntity<V2ExtendWorkflowRunFailedEventData>
    {
        /// <summary>
        /// A Stripe dashboard URL with more information about the Workflow Run failure.
        /// </summary>
        [JsonProperty("dashboard_url")]
        [STJS.JsonPropertyName("dashboard_url")]
        public string DashboardUrl { get; set; }

        /// <summary>
        /// Details about the Workflow Run's transition into the FAILED state.
        /// </summary>
        [JsonProperty("failure_details")]
        [STJS.JsonPropertyName("failure_details")]
        public V2ExtendWorkflowRunFailedEventDataFailureDetails FailureDetails { get; set; }
    }
}
