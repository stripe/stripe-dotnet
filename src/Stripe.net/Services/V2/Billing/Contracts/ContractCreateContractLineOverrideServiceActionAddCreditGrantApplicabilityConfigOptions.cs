// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractCreateContractLineOverrideServiceActionAddCreditGrantApplicabilityConfigOptions : INestedOptions
    {
        /// <summary>
        /// The applicability scope of the credit grant.
        /// </summary>
        [JsonProperty("scope")]
        [STJS.JsonPropertyName("scope")]
        public ContractCreateContractLineOverrideServiceActionAddCreditGrantApplicabilityConfigScopeOptions Scope { get; set; }
    }
}
