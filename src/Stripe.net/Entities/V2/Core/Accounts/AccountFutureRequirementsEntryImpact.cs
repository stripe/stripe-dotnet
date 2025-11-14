// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountFutureRequirementsEntryImpact : StripeEntity<AccountFutureRequirementsEntryImpact>
    {
        /// <summary>
        /// The Capabilities that will be restricted if the requirement is not collected and
        /// satisfactory to Stripe.
        /// </summary>
        [JsonProperty("restricts_capabilities")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("restricts_capabilities")]
#endif
        public List<AccountFutureRequirementsEntryImpactRestrictsCapability> RestrictsCapabilities { get; set; }
    }
}
