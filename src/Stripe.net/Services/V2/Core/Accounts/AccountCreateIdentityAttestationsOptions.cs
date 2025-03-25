// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountCreateIdentityAttestationsOptions : INestedOptions
    {
        /// <summary>
        /// This hash is used to attest that the directors information provided to Stripe is both
        /// current and correct.
        /// </summary>
        [JsonProperty("directorship_declaration")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("directorship_declaration")]
#endif
        public AccountCreateIdentityAttestationsDirectorshipDeclarationOptions DirectorshipDeclaration { get; set; }

        /// <summary>
        /// This hash is used to attest that the beneficial owner information provided to Stripe is
        /// both current and correct.
        /// </summary>
        [JsonProperty("ownership_declaration")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ownership_declaration")]
#endif
        public AccountCreateIdentityAttestationsOwnershipDeclarationOptions OwnershipDeclaration { get; set; }

        /// <summary>
        /// Attestation that all Persons with a specific Relationship value have been provided.
        /// </summary>
        [JsonProperty("persons_provided")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("persons_provided")]
#endif
        public AccountCreateIdentityAttestationsPersonsProvidedOptions PersonsProvided { get; set; }

        /// <summary>
        /// Attestations of accepted terms of service agreements.
        /// </summary>
        [JsonProperty("terms_of_service")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("terms_of_service")]
#endif
        public AccountCreateIdentityAttestationsTermsOfServiceOptions TermsOfService { get; set; }
    }
}
