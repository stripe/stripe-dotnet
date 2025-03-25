// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Accounts
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PersonUpdateDocumentsOptions : INestedOptions
    {
        /// <summary>
        /// One or more documents that demonstrate proof that this person is authorized to represent
        /// the company.
        /// </summary>
        [JsonProperty("company_authorization")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("company_authorization")]
#endif
        public PersonUpdateDocumentsCompanyAuthorizationOptions CompanyAuthorization { get; set; }

        /// <summary>
        /// One or more documents showing the person’s passport page with photo and personal data.
        /// </summary>
        [JsonProperty("passport")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("passport")]
#endif
        public PersonUpdateDocumentsPassportOptions Passport { get; set; }

        [JsonProperty("primary_verification")]
        [JsonConverter(typeof(EmptyableConverter<PersonUpdateDocumentsPrimaryVerificationOptions>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("primary_verification")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<PersonUpdateDocumentsPrimaryVerificationOptions>))]
#endif
        internal Emptyable<PersonUpdateDocumentsPrimaryVerificationOptions> InternalPrimaryVerification { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyPrimaryVerification
        {
            get => this.InternalPrimaryVerification?.Empty ?? false;
            set
            {
                this.InternalPrimaryVerification ??= new Emptyable<PersonUpdateDocumentsPrimaryVerificationOptions>();
                this.InternalPrimaryVerification.Empty = value;
            }
        }

        /// <summary>
        /// An identifying document showing the person's name, either a passport or local ID card.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public PersonUpdateDocumentsPrimaryVerificationOptions PrimaryVerification
        {
            get => this.InternalPrimaryVerification?.Value;
            set
            {
                this.InternalPrimaryVerification ??= new Emptyable<PersonUpdateDocumentsPrimaryVerificationOptions>();
                this.InternalPrimaryVerification.Value = value;
            }
        }

        [JsonProperty("secondary_verification")]
        [JsonConverter(typeof(EmptyableConverter<PersonUpdateDocumentsSecondaryVerificationOptions>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("secondary_verification")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<PersonUpdateDocumentsSecondaryVerificationOptions>))]
#endif
        internal Emptyable<PersonUpdateDocumentsSecondaryVerificationOptions> InternalSecondaryVerification { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptySecondaryVerification
        {
            get => this.InternalSecondaryVerification?.Empty ?? false;
            set
            {
                this.InternalSecondaryVerification ??= new Emptyable<PersonUpdateDocumentsSecondaryVerificationOptions>();
                this.InternalSecondaryVerification.Empty = value;
            }
        }

        /// <summary>
        /// A document showing address, either a passport, local ID card, or utility bill from a
        /// well-known utility company.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public PersonUpdateDocumentsSecondaryVerificationOptions SecondaryVerification
        {
            get => this.InternalSecondaryVerification?.Value;
            set
            {
                this.InternalSecondaryVerification ??= new Emptyable<PersonUpdateDocumentsSecondaryVerificationOptions>();
                this.InternalSecondaryVerification.Value = value;
            }
        }

        /// <summary>
        /// One or more documents showing the person’s visa required for living in the country where
        /// they are residing.
        /// </summary>
        [JsonProperty("visa")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("visa")]
#endif
        public PersonUpdateDocumentsVisaOptions Visa { get; set; }
    }
}
