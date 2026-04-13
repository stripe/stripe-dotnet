// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class WorkflowRunStatusDetailsSucceeded : StripeEntity<WorkflowRunStatusDetailsSucceeded>
    {
        /// <summary>
        /// Category of the success result.
        /// </summary>
        [JsonProperty("status_code")]
        [STJS.JsonPropertyName("status_code")]
        public string StatusCode { get; set; }

        /// <summary>
        /// Optional details about the success result.
        /// </summary>
        [JsonProperty("status_message")]
        [STJS.JsonPropertyName("status_message")]
        public string StatusMessage { get; set; }
    }
}
