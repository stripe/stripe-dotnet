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
