// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountFutureRequirementsEntryImpact : StripeEntity<AccountFutureRequirementsEntryImpact>
    {
        /// <summary>
        /// The Capabilities that will be restricted if the requirement is not collected and
        /// satisfactory to Stripe.
        /// </summary>
        [JsonProperty("restricts_capabilities")]
        [STJS.JsonPropertyName("restricts_capabilities")]
        public List<AccountFutureRequirementsEntryImpactRestrictsCapability> RestrictsCapabilities { get; set; }
    }
}
