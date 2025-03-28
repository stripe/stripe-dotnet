// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountRequirementsEntryImpact : StripeEntity<AccountRequirementsEntryImpact>
    {
        /// <summary>
        /// The Capabilities that will be restricted if the requirement is not collected and
        /// satisfactory to Stripe.
        /// </summary>
        [JsonProperty("restricts_capabilities")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("restricts_capabilities")]
#endif
        public List<AccountRequirementsEntryImpactRestrictsCapability> RestrictsCapabilities { get; set; }

        /// <summary>
        /// Details about payouts restrictions that will be enforced if the requirement is not
        /// collected and satisfactory to Stripe.
        /// </summary>
        [JsonProperty("restricts_payouts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("restricts_payouts")]
#endif
        public AccountRequirementsEntryImpactRestrictsPayouts RestrictsPayouts { get; set; }
    }
}
