// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2ExtendWorkflowRunFailedEventDataFailureDetails : StripeEntity<V2ExtendWorkflowRunFailedEventDataFailureDetails>
    {
        /// <summary>
        /// Optional details about the failure result.
        /// </summary>
        [JsonProperty("error_message")]
        [STJS.JsonPropertyName("error_message")]
        public string ErrorMessage { get; set; }
    }
}
