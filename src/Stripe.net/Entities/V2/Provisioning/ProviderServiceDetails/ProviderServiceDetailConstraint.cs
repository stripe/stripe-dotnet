// File generated from our OpenAPI spec
namespace Stripe.V2.Provisioning
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ProviderServiceDetailConstraint : StripeEntity<ProviderServiceDetailConstraint>
    {
        /// <summary>
        /// Limit on the number of active resources for the service.
        /// </summary>
        [JsonProperty("count")]
        [STJS.JsonPropertyName("count")]
        public ProviderServiceDetailConstraintCount Count { get; set; }

        /// <summary>
        /// Whether provisioning is blocked when an allowed-update target is active in the same
        /// scope.
        /// </summary>
        [JsonProperty("mutual_exclusion_allowed_updates")]
        [STJS.JsonPropertyName("mutual_exclusion_allowed_updates")]
        public bool? MutualExclusionAllowedUpdates { get; set; }

        /// <summary>
        /// Kind of constraint represented by this entry.
        /// One of: <c>count</c>, or <c>mutual_exclusion_allowed_updates</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
