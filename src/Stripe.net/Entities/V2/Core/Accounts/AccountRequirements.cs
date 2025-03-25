// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountRequirements : StripeEntity<AccountRequirements>
    {
        /// <summary>
        /// A value indicating responsibility for collecting requirements on this account.
        /// One of: <c>application</c>, or <c>stripe</c>.
        /// </summary>
        [JsonProperty("collector")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("collector")]
#endif
        public string Collector { get; set; }

        /// <summary>
        /// A list of requirements for the Account.
        /// </summary>
        [JsonProperty("entries")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("entries")]
#endif
        public List<AccountRequirementsEntry> Entries { get; set; }

        /// <summary>
        /// An object containing an overview of requirements for the Account.
        /// </summary>
        [JsonProperty("summary")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("summary")]
#endif
        public AccountRequirementsSummary Summary { get; set; }
    }
}
