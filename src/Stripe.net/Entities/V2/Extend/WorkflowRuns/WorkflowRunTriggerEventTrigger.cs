// File generated from our OpenAPI spec
namespace Stripe.V2.Extend
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class WorkflowRunTriggerEventTrigger : StripeEntity<WorkflowRunTriggerEventTrigger>, IHasId
    {
        /// <summary>
        /// The account that generated the triggering event.
        /// </summary>
        [JsonProperty("context")]
        [STJS.JsonPropertyName("context")]
        public string Context { get; set; }

        /// <summary>
        /// The Stripe event that triggered this Run.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The Stripe event type triggered this Run.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
