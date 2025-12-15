// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CapabilityFutureRequirementsAlternative : StripeEntity<CapabilityFutureRequirementsAlternative>
    {
        /// <summary>
        /// Fields that can be provided to resolve all fields in <c>original_fields_due</c>.
        /// </summary>
        [JsonProperty("alternative_fields_due")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("alternative_fields_due")]
#endif
        public List<string> AlternativeFieldsDue { get; set; }

        /// <summary>
        /// Fields that are due and can be resolved by providing all fields in
        /// <c>alternative_fields_due</c>.
        /// </summary>
        [JsonProperty("original_fields_due")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("original_fields_due")]
#endif
        public List<string> OriginalFieldsDue { get; set; }
    }
}
