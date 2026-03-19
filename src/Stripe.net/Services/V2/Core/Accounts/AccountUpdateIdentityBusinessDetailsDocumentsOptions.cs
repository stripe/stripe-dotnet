// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateIdentityBusinessDetailsDocumentsOptions : INestedOptions
    {
        /// <summary>
        /// One or more documents that support the bank account ownership verification requirement.
        /// Must be a document associated with the account’s primary active bank account that
        /// displays the last 4 digits of the account number, either a statement or a check.
        /// </summary>
        [JsonProperty("bank_account_ownership_verification")]
        [STJS.JsonPropertyName("bank_account_ownership_verification")]
        public AccountUpdateIdentityBusinessDetailsDocumentsBankAccountOwnershipVerificationOptions BankAccountOwnershipVerification { get; set; }

        /// <summary>
        /// One or more documents that demonstrate proof of a company’s license to operate.
        /// </summary>
        [JsonProperty("company_license")]
        [STJS.JsonPropertyName("company_license")]
        public AccountUpdateIdentityBusinessDetailsDocumentsCompanyLicenseOptions CompanyLicense { get; set; }

        /// <summary>
        /// One or more documents showing the company’s Memorandum of Association.
        /// </summary>
        [JsonProperty("company_memorandum_of_association")]
        [STJS.JsonPropertyName("company_memorandum_of_association")]
        public AccountUpdateIdentityBusinessDetailsDocumentsCompanyMemorandumOfAssociationOptions CompanyMemorandumOfAssociation { get; set; }

        /// <summary>
        /// Certain countries only: One or more documents showing the ministerial decree legalizing
        /// the company’s establishment.
        /// </summary>
        [JsonProperty("company_ministerial_decree")]
        [STJS.JsonPropertyName("company_ministerial_decree")]
        public AccountUpdateIdentityBusinessDetailsDocumentsCompanyMinisterialDecreeOptions CompanyMinisterialDecree { get; set; }

        /// <summary>
        /// One or more documents that demonstrate proof of a company’s registration with the
        /// appropriate local authorities.
        /// </summary>
        [JsonProperty("company_registration_verification")]
        [STJS.JsonPropertyName("company_registration_verification")]
        public AccountUpdateIdentityBusinessDetailsDocumentsCompanyRegistrationVerificationOptions CompanyRegistrationVerification { get; set; }

        /// <summary>
        /// One or more documents that demonstrate proof of a company’s tax ID.
        /// </summary>
        [JsonProperty("company_tax_id_verification")]
        [STJS.JsonPropertyName("company_tax_id_verification")]
        public AccountUpdateIdentityBusinessDetailsDocumentsCompanyTaxIdVerificationOptions CompanyTaxIdVerification { get; set; }

        /// <summary>
        /// A document verifying the business.
        /// </summary>
        [JsonProperty("primary_verification")]
        [STJS.JsonPropertyName("primary_verification")]
        public AccountUpdateIdentityBusinessDetailsDocumentsPrimaryVerificationOptions PrimaryVerification { get; set; }

        /// <summary>
        /// One or more documents that demonstrate proof of address.
        /// </summary>
        [JsonProperty("proof_of_address")]
        [STJS.JsonPropertyName("proof_of_address")]
        public AccountUpdateIdentityBusinessDetailsDocumentsProofOfAddressOptions ProofOfAddress { get; set; }

        /// <summary>
        /// One or more documents showing the company’s proof of registration with the national
        /// business registry.
        /// </summary>
        [JsonProperty("proof_of_registration")]
        [STJS.JsonPropertyName("proof_of_registration")]
        public AccountUpdateIdentityBusinessDetailsDocumentsProofOfRegistrationOptions ProofOfRegistration { get; set; }

        /// <summary>
        /// One or more documents that demonstrate proof of ultimate beneficial ownership.
        /// </summary>
        [JsonProperty("proof_of_ultimate_beneficial_ownership")]
        [STJS.JsonPropertyName("proof_of_ultimate_beneficial_ownership")]
        public AccountUpdateIdentityBusinessDetailsDocumentsProofOfUltimateBeneficialOwnershipOptions ProofOfUltimateBeneficialOwnership { get; set; }
    }
}
