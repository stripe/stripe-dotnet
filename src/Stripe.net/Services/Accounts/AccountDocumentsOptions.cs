// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountDocumentsOptions : INestedOptions
    {
        /// <summary>
        /// One or more documents that support the <a
        /// href="https://support.stripe.com/questions/bank-account-ownership-verification">Bank
        /// account ownership verification</a> requirement. Must be a document associated with the
        /// account’s primary active bank account that displays the last 4 digits of the account
        /// number, either a statement or a check.
        /// </summary>
        [JsonProperty("bank_account_ownership_verification")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_account_ownership_verification")]
#endif
        public AccountDocumentsBankAccountOwnershipVerificationOptions BankAccountOwnershipVerification { get; set; }

        /// <summary>
        /// One or more documents that demonstrate proof of a company's license to operate.
        /// </summary>
        [JsonProperty("company_license")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("company_license")]
#endif
        public AccountDocumentsCompanyLicenseOptions CompanyLicense { get; set; }

        /// <summary>
        /// One or more documents showing the company's Memorandum of Association.
        /// </summary>
        [JsonProperty("company_memorandum_of_association")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("company_memorandum_of_association")]
#endif
        public AccountDocumentsCompanyMemorandumOfAssociationOptions CompanyMemorandumOfAssociation { get; set; }

        /// <summary>
        /// (Certain countries only) One or more documents showing the ministerial decree legalizing
        /// the company's establishment.
        /// </summary>
        [JsonProperty("company_ministerial_decree")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("company_ministerial_decree")]
#endif
        public AccountDocumentsCompanyMinisterialDecreeOptions CompanyMinisterialDecree { get; set; }

        /// <summary>
        /// One or more documents that demonstrate proof of a company's registration with the
        /// appropriate local authorities.
        /// </summary>
        [JsonProperty("company_registration_verification")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("company_registration_verification")]
#endif
        public AccountDocumentsCompanyRegistrationVerificationOptions CompanyRegistrationVerification { get; set; }

        /// <summary>
        /// One or more documents that demonstrate proof of a company's tax ID.
        /// </summary>
        [JsonProperty("company_tax_id_verification")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("company_tax_id_verification")]
#endif
        public AccountDocumentsCompanyTaxIdVerificationOptions CompanyTaxIdVerification { get; set; }

        /// <summary>
        /// One or more documents showing the company’s proof of registration with the national
        /// business registry.
        /// </summary>
        [JsonProperty("proof_of_registration")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("proof_of_registration")]
#endif
        public AccountDocumentsProofOfRegistrationOptions ProofOfRegistration { get; set; }
    }
}
