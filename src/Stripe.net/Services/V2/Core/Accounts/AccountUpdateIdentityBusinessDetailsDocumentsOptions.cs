// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class AccountUpdateIdentityBusinessDetailsDocumentsOptions : INestedOptions
    {
        [JsonProperty("bank_account_ownership_verification")]
        [JsonConverter(typeof(EmptyableConverter<AccountUpdateIdentityBusinessDetailsDocumentsBankAccountOwnershipVerificationOptions>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_account_ownership_verification")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<AccountUpdateIdentityBusinessDetailsDocumentsBankAccountOwnershipVerificationOptions>))]
#endif
        internal Emptyable<AccountUpdateIdentityBusinessDetailsDocumentsBankAccountOwnershipVerificationOptions> InternalBankAccountOwnershipVerification { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyBankAccountOwnershipVerification
        {
            get => this.InternalBankAccountOwnershipVerification?.Empty ?? false;
            set
            {
                this.InternalBankAccountOwnershipVerification ??= new Emptyable<AccountUpdateIdentityBusinessDetailsDocumentsBankAccountOwnershipVerificationOptions>();
                this.InternalBankAccountOwnershipVerification.Empty = value;
            }
        }

        /// <summary>
        /// One or more documents that support the bank account ownership verification requirement.
        /// Must be a document associated with the account’s primary active bank account that
        /// displays the last 4 digits of the account number, either a statement or a check.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public AccountUpdateIdentityBusinessDetailsDocumentsBankAccountOwnershipVerificationOptions BankAccountOwnershipVerification
        {
            get => this.InternalBankAccountOwnershipVerification?.Value;
            set
            {
                this.InternalBankAccountOwnershipVerification ??= new Emptyable<AccountUpdateIdentityBusinessDetailsDocumentsBankAccountOwnershipVerificationOptions>();
                this.InternalBankAccountOwnershipVerification.Value = value;
            }
        }

        [JsonProperty("company_license")]
        [JsonConverter(typeof(EmptyableConverter<AccountUpdateIdentityBusinessDetailsDocumentsCompanyLicenseOptions>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("company_license")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<AccountUpdateIdentityBusinessDetailsDocumentsCompanyLicenseOptions>))]
#endif
        internal Emptyable<AccountUpdateIdentityBusinessDetailsDocumentsCompanyLicenseOptions> InternalCompanyLicense { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyCompanyLicense
        {
            get => this.InternalCompanyLicense?.Empty ?? false;
            set
            {
                this.InternalCompanyLicense ??= new Emptyable<AccountUpdateIdentityBusinessDetailsDocumentsCompanyLicenseOptions>();
                this.InternalCompanyLicense.Empty = value;
            }
        }

        /// <summary>
        /// One or more documents that demonstrate proof of a company’s license to operate.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public AccountUpdateIdentityBusinessDetailsDocumentsCompanyLicenseOptions CompanyLicense
        {
            get => this.InternalCompanyLicense?.Value;
            set
            {
                this.InternalCompanyLicense ??= new Emptyable<AccountUpdateIdentityBusinessDetailsDocumentsCompanyLicenseOptions>();
                this.InternalCompanyLicense.Value = value;
            }
        }

        [JsonProperty("company_memorandum_of_association")]
        [JsonConverter(typeof(EmptyableConverter<AccountUpdateIdentityBusinessDetailsDocumentsCompanyMemorandumOfAssociationOptions>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("company_memorandum_of_association")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<AccountUpdateIdentityBusinessDetailsDocumentsCompanyMemorandumOfAssociationOptions>))]
#endif
        internal Emptyable<AccountUpdateIdentityBusinessDetailsDocumentsCompanyMemorandumOfAssociationOptions> InternalCompanyMemorandumOfAssociation { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyCompanyMemorandumOfAssociation
        {
            get => this.InternalCompanyMemorandumOfAssociation?.Empty ?? false;
            set
            {
                this.InternalCompanyMemorandumOfAssociation ??= new Emptyable<AccountUpdateIdentityBusinessDetailsDocumentsCompanyMemorandumOfAssociationOptions>();
                this.InternalCompanyMemorandumOfAssociation.Empty = value;
            }
        }

        /// <summary>
        /// One or more documents showing the company’s Memorandum of Association.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public AccountUpdateIdentityBusinessDetailsDocumentsCompanyMemorandumOfAssociationOptions CompanyMemorandumOfAssociation
        {
            get => this.InternalCompanyMemorandumOfAssociation?.Value;
            set
            {
                this.InternalCompanyMemorandumOfAssociation ??= new Emptyable<AccountUpdateIdentityBusinessDetailsDocumentsCompanyMemorandumOfAssociationOptions>();
                this.InternalCompanyMemorandumOfAssociation.Value = value;
            }
        }

        [JsonProperty("company_ministerial_decree")]
        [JsonConverter(typeof(EmptyableConverter<AccountUpdateIdentityBusinessDetailsDocumentsCompanyMinisterialDecreeOptions>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("company_ministerial_decree")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<AccountUpdateIdentityBusinessDetailsDocumentsCompanyMinisterialDecreeOptions>))]
#endif
        internal Emptyable<AccountUpdateIdentityBusinessDetailsDocumentsCompanyMinisterialDecreeOptions> InternalCompanyMinisterialDecree { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyCompanyMinisterialDecree
        {
            get => this.InternalCompanyMinisterialDecree?.Empty ?? false;
            set
            {
                this.InternalCompanyMinisterialDecree ??= new Emptyable<AccountUpdateIdentityBusinessDetailsDocumentsCompanyMinisterialDecreeOptions>();
                this.InternalCompanyMinisterialDecree.Empty = value;
            }
        }

        /// <summary>
        /// Certain countries only: One or more documents showing the ministerial decree legalizing
        /// the company’s establishment.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public AccountUpdateIdentityBusinessDetailsDocumentsCompanyMinisterialDecreeOptions CompanyMinisterialDecree
        {
            get => this.InternalCompanyMinisterialDecree?.Value;
            set
            {
                this.InternalCompanyMinisterialDecree ??= new Emptyable<AccountUpdateIdentityBusinessDetailsDocumentsCompanyMinisterialDecreeOptions>();
                this.InternalCompanyMinisterialDecree.Value = value;
            }
        }

        [JsonProperty("company_registration_verification")]
        [JsonConverter(typeof(EmptyableConverter<AccountUpdateIdentityBusinessDetailsDocumentsCompanyRegistrationVerificationOptions>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("company_registration_verification")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<AccountUpdateIdentityBusinessDetailsDocumentsCompanyRegistrationVerificationOptions>))]
#endif
        internal Emptyable<AccountUpdateIdentityBusinessDetailsDocumentsCompanyRegistrationVerificationOptions> InternalCompanyRegistrationVerification { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyCompanyRegistrationVerification
        {
            get => this.InternalCompanyRegistrationVerification?.Empty ?? false;
            set
            {
                this.InternalCompanyRegistrationVerification ??= new Emptyable<AccountUpdateIdentityBusinessDetailsDocumentsCompanyRegistrationVerificationOptions>();
                this.InternalCompanyRegistrationVerification.Empty = value;
            }
        }

        /// <summary>
        /// One or more documents that demonstrate proof of a company’s registration with the
        /// appropriate local authorities.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public AccountUpdateIdentityBusinessDetailsDocumentsCompanyRegistrationVerificationOptions CompanyRegistrationVerification
        {
            get => this.InternalCompanyRegistrationVerification?.Value;
            set
            {
                this.InternalCompanyRegistrationVerification ??= new Emptyable<AccountUpdateIdentityBusinessDetailsDocumentsCompanyRegistrationVerificationOptions>();
                this.InternalCompanyRegistrationVerification.Value = value;
            }
        }

        [JsonProperty("company_tax_id_verification")]
        [JsonConverter(typeof(EmptyableConverter<AccountUpdateIdentityBusinessDetailsDocumentsCompanyTaxIdVerificationOptions>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("company_tax_id_verification")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<AccountUpdateIdentityBusinessDetailsDocumentsCompanyTaxIdVerificationOptions>))]
#endif
        internal Emptyable<AccountUpdateIdentityBusinessDetailsDocumentsCompanyTaxIdVerificationOptions> InternalCompanyTaxIdVerification { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyCompanyTaxIdVerification
        {
            get => this.InternalCompanyTaxIdVerification?.Empty ?? false;
            set
            {
                this.InternalCompanyTaxIdVerification ??= new Emptyable<AccountUpdateIdentityBusinessDetailsDocumentsCompanyTaxIdVerificationOptions>();
                this.InternalCompanyTaxIdVerification.Empty = value;
            }
        }

        /// <summary>
        /// One or more documents that demonstrate proof of a company’s tax ID.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public AccountUpdateIdentityBusinessDetailsDocumentsCompanyTaxIdVerificationOptions CompanyTaxIdVerification
        {
            get => this.InternalCompanyTaxIdVerification?.Value;
            set
            {
                this.InternalCompanyTaxIdVerification ??= new Emptyable<AccountUpdateIdentityBusinessDetailsDocumentsCompanyTaxIdVerificationOptions>();
                this.InternalCompanyTaxIdVerification.Value = value;
            }
        }

        [JsonProperty("primary_verification")]
        [JsonConverter(typeof(EmptyableConverter<AccountUpdateIdentityBusinessDetailsDocumentsPrimaryVerificationOptions>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("primary_verification")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<AccountUpdateIdentityBusinessDetailsDocumentsPrimaryVerificationOptions>))]
#endif
        internal Emptyable<AccountUpdateIdentityBusinessDetailsDocumentsPrimaryVerificationOptions> InternalPrimaryVerification { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyPrimaryVerification
        {
            get => this.InternalPrimaryVerification?.Empty ?? false;
            set
            {
                this.InternalPrimaryVerification ??= new Emptyable<AccountUpdateIdentityBusinessDetailsDocumentsPrimaryVerificationOptions>();
                this.InternalPrimaryVerification.Empty = value;
            }
        }

        /// <summary>
        /// A document verifying the business.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public AccountUpdateIdentityBusinessDetailsDocumentsPrimaryVerificationOptions PrimaryVerification
        {
            get => this.InternalPrimaryVerification?.Value;
            set
            {
                this.InternalPrimaryVerification ??= new Emptyable<AccountUpdateIdentityBusinessDetailsDocumentsPrimaryVerificationOptions>();
                this.InternalPrimaryVerification.Value = value;
            }
        }

        [JsonProperty("proof_of_registration")]
        [JsonConverter(typeof(EmptyableConverter<AccountUpdateIdentityBusinessDetailsDocumentsProofOfRegistrationOptions>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("proof_of_registration")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<AccountUpdateIdentityBusinessDetailsDocumentsProofOfRegistrationOptions>))]
#endif
        internal Emptyable<AccountUpdateIdentityBusinessDetailsDocumentsProofOfRegistrationOptions> InternalProofOfRegistration { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyProofOfRegistration
        {
            get => this.InternalProofOfRegistration?.Empty ?? false;
            set
            {
                this.InternalProofOfRegistration ??= new Emptyable<AccountUpdateIdentityBusinessDetailsDocumentsProofOfRegistrationOptions>();
                this.InternalProofOfRegistration.Empty = value;
            }
        }

        /// <summary>
        /// One or more documents showing the company’s proof of registration with the national
        /// business registry.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public AccountUpdateIdentityBusinessDetailsDocumentsProofOfRegistrationOptions ProofOfRegistration
        {
            get => this.InternalProofOfRegistration?.Value;
            set
            {
                this.InternalProofOfRegistration ??= new Emptyable<AccountUpdateIdentityBusinessDetailsDocumentsProofOfRegistrationOptions>();
                this.InternalProofOfRegistration.Value = value;
            }
        }

        /// <summary>
        /// One or more documents that demonstrate proof of ultimate beneficial ownership.
        /// </summary>
        [JsonProperty("proof_of_ultimate_beneficial_ownership")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("proof_of_ultimate_beneficial_ownership")]
#endif
        public AccountUpdateIdentityBusinessDetailsDocumentsProofOfUltimateBeneficialOwnershipOptions ProofOfUltimateBeneficialOwnership { get; set; }
    }
}
