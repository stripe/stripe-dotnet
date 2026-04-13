// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class IntentCreateActionOptions : INestedOptions
    {
        /// <summary>
        /// Details for an apply action.
        /// </summary>
        [JsonProperty("apply")]
        [STJS.JsonPropertyName("apply")]
        public IntentCreateActionApplyOptions Apply { get; set; }

        /// <summary>
        /// Details for a deactivate action.
        /// </summary>
        [JsonProperty("deactivate")]
        [STJS.JsonPropertyName("deactivate")]
        public IntentCreateActionDeactivateOptions Deactivate { get; set; }

        /// <summary>
        /// Details for a modify action.
        /// </summary>
        [JsonProperty("modify")]
        [STJS.JsonPropertyName("modify")]
        public IntentCreateActionModifyOptions Modify { get; set; }

        /// <summary>
        /// Details for a remove action.
        /// </summary>
        [JsonProperty("remove")]
        [STJS.JsonPropertyName("remove")]
        public IntentCreateActionRemoveOptions Remove { get; set; }

        /// <summary>
        /// Details for a subscribe action.
        /// </summary>
        [JsonProperty("subscribe")]
        [STJS.JsonPropertyName("subscribe")]
        public IntentCreateActionSubscribeOptions Subscribe { get; set; }

        /// <summary>
        /// Type of the Billing Intent action.
        /// One of: <c>apply</c>, <c>deactivate</c>, <c>modify</c>, <c>remove</c>, or
        /// <c>subscribe</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
