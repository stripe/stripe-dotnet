// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountFutureRequirementsAlternative : StripeEntity<AccountFutureRequirementsAlternative>
    {
        /// <summary>
        /// The alternative sets of requirements that can be provided. Providing every entry in any
        /// one of these options resolves all of the requirements in <c>original_entries</c>.
        /// </summary>
        [JsonProperty("options")]
        [STJS.JsonPropertyName("options")]
        public List<AccountFutureRequirementsAlternativeOption> Options { get; set; }

        /// <summary>
        /// The requirements that can be satisfied either directly, or by providing every entry in
        /// any one of <c>options</c>.
        /// </summary>
        [JsonProperty("original_entries")]
        [STJS.JsonPropertyName("original_entries")]
        public List<AccountFutureRequirementsAlternativeOriginalEntry> OriginalEntries { get; set; }
    }
}
