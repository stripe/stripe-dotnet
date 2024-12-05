// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CapabilityRequirementsAlternative : StripeEntity<CapabilityRequirementsAlternative>
    {
        /// <summary>
        /// Fields that can be provided to satisfy all fields in <c>original_fields_due</c>.
        /// </summary>
        [JsonProperty("alternative_fields_due")]
        public List<string> AlternativeFieldsDue { get; set; }

        /// <summary>
        /// Fields that are due and can be satisfied by providing all fields in
        /// <c>alternative_fields_due</c>.
        /// </summary>
        [JsonProperty("original_fields_due")]
        public List<string> OriginalFieldsDue { get; set; }
    }
}
