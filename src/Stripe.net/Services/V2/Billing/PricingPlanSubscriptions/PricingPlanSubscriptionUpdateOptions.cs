// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PricingPlanSubscriptionUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// When set to true, the <c>servicing_status_transition.will_cancel_at</c> field will be
        /// cleared.
        /// </summary>
        [JsonProperty("clear_cancel_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("clear_cancel_at")]
#endif
        public bool? ClearCancelAt { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }
    }
}
