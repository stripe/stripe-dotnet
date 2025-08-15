// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class IntentCreateActionOptions : INestedOptions
    {
        /// <summary>
        /// Type of the BillingIntentAction.
        /// One of: <c>apply</c>, <c>deactivate</c>, <c>modify</c>, <c>remove</c>, or
        /// <c>subscribe</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// Details for an apply action.
        /// </summary>
        [JsonProperty("apply")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("apply")]
#endif
        public IntentCreateActionApplyOptions Apply { get; set; }

        /// <summary>
        /// Details for a deactivate action.
        /// </summary>
        [JsonProperty("deactivate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("deactivate")]
#endif
        public IntentCreateActionDeactivateOptions Deactivate { get; set; }

        /// <summary>
        /// Details for a modify action.
        /// </summary>
        [JsonProperty("modify")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("modify")]
#endif
        public IntentCreateActionModifyOptions Modify { get; set; }

        /// <summary>
        /// Details for a remove action.
        /// </summary>
        [JsonProperty("remove")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("remove")]
#endif
        public IntentCreateActionRemoveOptions Remove { get; set; }

        /// <summary>
        /// Details for a subscribe action.
        /// </summary>
        [JsonProperty("subscribe")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscribe")]
#endif
        public IntentCreateActionSubscribeOptions Subscribe { get; set; }
    }
}
