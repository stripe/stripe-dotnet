// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountRequirementImpact : StripeEntity<AccountRequirementImpact>
    {
        /// <summary>
        /// Open Enum. The set of Features that are restricted by this requirement.
        /// One of: <c>bank_accounts.local</c>, <c>bank_accounts.wire</c>, or <c>cards</c>.
        /// </summary>
        [JsonProperty("required_for_features")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("required_for_features")]
#endif
        public List<string> RequiredForFeatures { get; set; }
    }
}
