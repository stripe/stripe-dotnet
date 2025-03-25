// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountUpdateIdentityAttestationsPersonsProvidedOptions : INestedOptions
    {
        /// <summary>
        /// Whether the company’s directors have been provided. Set this Boolean to true after
        /// creating all the company’s directors with the <a
        /// href="https://docs.stripe.com/api/v2/core/accounts/createperson">Persons API</a>.
        /// </summary>
        [JsonProperty("directors")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("directors")]
#endif
        public bool? Directors { get; set; }

        /// <summary>
        /// Whether the company’s executives have been provided. Set this Boolean to true after
        /// creating all the company’s executives with the <a
        /// href="https://docs.stripe.com/api/v2/core/accounts/createperson">Persons API</a>.
        /// </summary>
        [JsonProperty("executives")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("executives")]
#endif
        public bool? Executives { get; set; }

        /// <summary>
        /// Whether the company’s owners have been provided. Set this Boolean to true after creating
        /// all the company’s owners with the <a
        /// href="https://docs.stripe.com/api/v2/core/accounts/createperson">Persons API</a>.
        /// </summary>
        [JsonProperty("owners")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("owners")]
#endif
        public bool? Owners { get; set; }

        /// <summary>
        /// Reason for why the company is exempt from providing ownership information.
        /// One of: <c>qualified_entity_exceeds_ownership_threshold</c>, or
        /// <c>qualifies_as_financial_institution</c>.
        /// </summary>
        [JsonProperty("ownership_exemption_reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ownership_exemption_reason")]
#endif
        public string OwnershipExemptionReason { get; set; }
    }
}
