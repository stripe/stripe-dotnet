// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractContractLineDetailOverrideServiceActionReplaceCreditGrantApplicabilityConfig : StripeEntity<ContractContractLineDetailOverrideServiceActionReplaceCreditGrantApplicabilityConfig>
    {
        /// <summary>
        /// The applicability scope of the credit grant.
        /// </summary>
        [JsonProperty("scope")]
        [STJS.JsonPropertyName("scope")]
        public ContractContractLineDetailOverrideServiceActionReplaceCreditGrantApplicabilityConfigScope Scope { get; set; }
    }
}
