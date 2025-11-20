// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountTokenCreateIdentityAttestationsOptions : INestedOptions
    {
        /// <summary>
        /// This hash is used to attest that the directors information provided to Stripe is both
        /// current and correct; IP, date, and User Agent are expanded by Stripe.
        /// </summary>
        [JsonProperty("directorship_declaration")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("directorship_declaration")]
#endif
        public AccountTokenCreateIdentityAttestationsDirectorshipDeclarationOptions DirectorshipDeclaration { get; set; }

        /// <summary>
        /// This hash is used to attest that the beneficial owner information provided to Stripe is
        /// both current and correct; IP, date, and User Agent are expanded by Stripe.
        /// </summary>
        [JsonProperty("ownership_declaration")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ownership_declaration")]
#endif
        public AccountTokenCreateIdentityAttestationsOwnershipDeclarationOptions OwnershipDeclaration { get; set; }

        /// <summary>
        /// Attestation that all Persons with a specific Relationship value have been provided.
        /// </summary>
        [JsonProperty("persons_provided")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("persons_provided")]
#endif
        public AccountTokenCreateIdentityAttestationsPersonsProvidedOptions PersonsProvided { get; set; }

        /// <summary>
        /// This hash is used to attest that the representative is authorized to act as the
        /// representative of their legal entity; IP, date, and User Agent are expanded by Stripe.
        /// </summary>
        [JsonProperty("representative_declaration")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("representative_declaration")]
#endif
        public AccountTokenCreateIdentityAttestationsRepresentativeDeclarationOptions RepresentativeDeclaration { get; set; }

        /// <summary>
        /// Attestations of accepted terms of service agreements.
        /// </summary>
        [JsonProperty("terms_of_service")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("terms_of_service")]
#endif
        public AccountTokenCreateIdentityAttestationsTermsOfServiceOptions TermsOfService { get; set; }
    }
}
