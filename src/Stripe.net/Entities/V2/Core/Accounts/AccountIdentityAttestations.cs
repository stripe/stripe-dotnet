// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountIdentityAttestations : StripeEntity<AccountIdentityAttestations>
    {
        /// <summary>
        /// This hash is used to attest that the directors information provided to Stripe is both
        /// current and correct.
        /// </summary>
        [JsonProperty("directorship_declaration")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("directorship_declaration")]
#endif
        public AccountIdentityAttestationsDirectorshipDeclaration DirectorshipDeclaration { get; set; }

        /// <summary>
        /// This hash is used to attest that the beneficial owner information provided to Stripe is
        /// both current and correct.
        /// </summary>
        [JsonProperty("ownership_declaration")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ownership_declaration")]
#endif
        public AccountIdentityAttestationsOwnershipDeclaration OwnershipDeclaration { get; set; }

        /// <summary>
        /// Attestation that all Persons with a specific Relationship value have been provided.
        /// </summary>
        [JsonProperty("persons_provided")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("persons_provided")]
#endif
        public AccountIdentityAttestationsPersonsProvided PersonsProvided { get; set; }

        /// <summary>
        /// This hash is used to attest that the representative is authorized to act as the
        /// representative of their legal entity.
        /// </summary>
        [JsonProperty("representative_declaration")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("representative_declaration")]
#endif
        public AccountIdentityAttestationsRepresentativeDeclaration RepresentativeDeclaration { get; set; }

        /// <summary>
        /// Attestations of accepted terms of service agreements.
        /// </summary>
        [JsonProperty("terms_of_service")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("terms_of_service")]
#endif
        public AccountIdentityAttestationsTermsOfService TermsOfService { get; set; }
    }
}
