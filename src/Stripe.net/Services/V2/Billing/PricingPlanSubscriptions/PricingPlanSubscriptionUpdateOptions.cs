// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PricingPlanSubscriptionUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// When set to true, the <c>servicing_status_transition.will_cancel_at</c> field will be
        /// cleared.
        /// </summary>
        [JsonProperty("clear_cancel_at")]
        [STJS.JsonPropertyName("clear_cancel_at")]
        public bool? ClearCancelAt { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
