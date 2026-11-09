// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountRequirements : StripeEntity<AccountRequirements>
    {
        /// <summary>
        /// A list of alternative sets of requirements that can be provided in lieu of requirements
        /// in <c>entries</c>.
        /// </summary>
        [JsonProperty("alternatives")]
        [STJS.JsonPropertyName("alternatives")]
        public List<AccountRequirementsAlternative> Alternatives { get; set; }

        /// <summary>
        /// A list of requirements for the Account.
        /// </summary>
        [JsonProperty("entries")]
        [STJS.JsonPropertyName("entries")]
        public List<AccountRequirementsEntry> Entries { get; set; }

        /// <summary>
        /// An object containing an overview of requirements for the Account.
        /// </summary>
        [JsonProperty("summary")]
        [STJS.JsonPropertyName("summary")]
        public AccountRequirementsSummary Summary { get; set; }
    }
}
