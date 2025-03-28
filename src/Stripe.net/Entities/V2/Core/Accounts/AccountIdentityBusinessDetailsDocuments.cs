// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountIdentityBusinessDetailsDocuments : StripeEntity<AccountIdentityBusinessDetailsDocuments>
    {
        /// <summary>
        /// One or more documents that support the Bank account ownership verification requirement.
        /// Must be a document associated with the account’s primary active bank account that
        /// displays the last 4 digits of the account number, either a statement or a check.
        /// </summary>
        [JsonProperty("bank_account_ownership_verification")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_account_ownership_verification")]
#endif
        public AccountIdentityBusinessDetailsDocumentsBankAccountOwnershipVerification BankAccountOwnershipVerification { get; set; }

        /// <summary>
        /// One or more documents that demonstrate proof of a company’s license to operate.
        /// </summary>
        [JsonProperty("company_license")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("company_license")]
#endif
        public AccountIdentityBusinessDetailsDocumentsCompanyLicense CompanyLicense { get; set; }

        /// <summary>
        /// One or more documents showing the company’s Memorandum of Association.
        /// </summary>
        [JsonProperty("company_memorandum_of_association")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("company_memorandum_of_association")]
#endif
        public AccountIdentityBusinessDetailsDocumentsCompanyMemorandumOfAssociation CompanyMemorandumOfAssociation { get; set; }

        /// <summary>
        /// Certain countries only: One or more documents showing the ministerial decree legalizing
        /// the company’s establishment.
        /// </summary>
        [JsonProperty("company_ministerial_decree")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("company_ministerial_decree")]
#endif
        public AccountIdentityBusinessDetailsDocumentsCompanyMinisterialDecree CompanyMinisterialDecree { get; set; }

        /// <summary>
        /// One or more documents that demonstrate proof of a company’s registration with the
        /// appropriate local authorities.
        /// </summary>
        [JsonProperty("company_registration_verification")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("company_registration_verification")]
#endif
        public AccountIdentityBusinessDetailsDocumentsCompanyRegistrationVerification CompanyRegistrationVerification { get; set; }

        /// <summary>
        /// One or more documents that demonstrate proof of a company’s tax ID.
        /// </summary>
        [JsonProperty("company_tax_id_verification")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("company_tax_id_verification")]
#endif
        public AccountIdentityBusinessDetailsDocumentsCompanyTaxIdVerification CompanyTaxIdVerification { get; set; }

        /// <summary>
        /// A document verifying the business.
        /// </summary>
        [JsonProperty("primary_verification")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("primary_verification")]
#endif
        public AccountIdentityBusinessDetailsDocumentsPrimaryVerification PrimaryVerification { get; set; }

        /// <summary>
        /// One or more documents showing the company’s proof of registration with the national
        /// business registry.
        /// </summary>
        [JsonProperty("proof_of_registration")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("proof_of_registration")]
#endif
        public AccountIdentityBusinessDetailsDocumentsProofOfRegistration ProofOfRegistration { get; set; }

        /// <summary>
        /// One or more documents that demonstrate proof of ultimate beneficial ownership.
        /// </summary>
        [JsonProperty("proof_of_ultimate_beneficial_ownership")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("proof_of_ultimate_beneficial_ownership")]
#endif
        public AccountIdentityBusinessDetailsDocumentsProofOfUltimateBeneficialOwnership ProofOfUltimateBeneficialOwnership { get; set; }
    }
}
