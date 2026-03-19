// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountIdentityAttestations : StripeEntity<AccountIdentityAttestations>
    {
        /// <summary>
        /// This hash is used to attest that the directors information provided to Stripe is both
        /// current and correct.
        /// </summary>
        [JsonProperty("directorship_declaration")]
        [STJS.JsonPropertyName("directorship_declaration")]
        public AccountIdentityAttestationsDirectorshipDeclaration DirectorshipDeclaration { get; set; }

        /// <summary>
        /// This hash is used to attest that the beneficial owner information provided to Stripe is
        /// both current and correct.
        /// </summary>
        [JsonProperty("ownership_declaration")]
        [STJS.JsonPropertyName("ownership_declaration")]
        public AccountIdentityAttestationsOwnershipDeclaration OwnershipDeclaration { get; set; }

        /// <summary>
        /// Attestation that all Persons with a specific Relationship value have been provided.
        /// </summary>
        [JsonProperty("persons_provided")]
        [STJS.JsonPropertyName("persons_provided")]
        public AccountIdentityAttestationsPersonsProvided PersonsProvided { get; set; }

        /// <summary>
        /// This hash is used to attest that the representative is authorized to act as the
        /// representative of their legal entity.
        /// </summary>
        [JsonProperty("representative_declaration")]
        [STJS.JsonPropertyName("representative_declaration")]
        public AccountIdentityAttestationsRepresentativeDeclaration RepresentativeDeclaration { get; set; }

        /// <summary>
        /// Attestations of accepted terms of service agreements.
        /// </summary>
        [JsonProperty("terms_of_service")]
        [STJS.JsonPropertyName("terms_of_service")]
        public AccountIdentityAttestationsTermsOfService TermsOfService { get; set; }
    }
}
