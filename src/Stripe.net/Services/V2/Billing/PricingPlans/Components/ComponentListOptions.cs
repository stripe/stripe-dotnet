// File generated from our OpenAPI spec
namespace Stripe.V2.Billing.PricingPlans
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ComponentListOptions : V2.ListOptions
    {
        /// <summary>
        /// Filter by lookup keys. Mutually exclusive with <c>pricing_plan_version</c>. You can
        /// specify up to 10 lookup keys.
        /// </summary>
        [JsonProperty("lookup_keys")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lookup_keys")]
#endif
        public List<string> LookupKeys { get; set; }

        /// <summary>
        /// The ID of the Pricing Plan Version to list components for. Will use the latest version
        /// if not provided. Mutually exclusive with <c>lookup_keys</c>.
        /// </summary>
        [JsonProperty("pricing_plan_version")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pricing_plan_version")]
#endif
        public string PricingPlanVersion { get; set; }
    }
}
