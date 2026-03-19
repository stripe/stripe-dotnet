// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateIdentityAttestationsOptions : INestedOptions
    {
        /// <summary>
        /// This hash is used to attest that the directors information provided to Stripe is both
        /// current and correct.
        /// </summary>
        [JsonProperty("directorship_declaration")]
        [STJS.JsonPropertyName("directorship_declaration")]
        public AccountCreateIdentityAttestationsDirectorshipDeclarationOptions DirectorshipDeclaration { get; set; }

        /// <summary>
        /// This hash is used to attest that the beneficial owner information provided to Stripe is
        /// both current and correct.
        /// </summary>
        [JsonProperty("ownership_declaration")]
        [STJS.JsonPropertyName("ownership_declaration")]
        public AccountCreateIdentityAttestationsOwnershipDeclarationOptions OwnershipDeclaration { get; set; }

        /// <summary>
        /// Attestation that all Persons with a specific Relationship value have been provided.
        /// </summary>
        [JsonProperty("persons_provided")]
        [STJS.JsonPropertyName("persons_provided")]
        public AccountCreateIdentityAttestationsPersonsProvidedOptions PersonsProvided { get; set; }

        /// <summary>
        /// This hash is used to attest that the representative is authorized to act as the
        /// representative of their legal entity.
        /// </summary>
        [JsonProperty("representative_declaration")]
        [STJS.JsonPropertyName("representative_declaration")]
        public AccountCreateIdentityAttestationsRepresentativeDeclarationOptions RepresentativeDeclaration { get; set; }

        /// <summary>
        /// Attestations of accepted terms of service agreements.
        /// </summary>
        [JsonProperty("terms_of_service")]
        [STJS.JsonPropertyName("terms_of_service")]
        public AccountCreateIdentityAttestationsTermsOfServiceOptions TermsOfService { get; set; }
    }
}
