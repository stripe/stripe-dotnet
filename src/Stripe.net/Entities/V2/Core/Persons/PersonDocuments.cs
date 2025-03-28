// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PersonDocuments : StripeEntity<PersonDocuments>
    {
        /// <summary>
        /// One or more documents that demonstrate proof that this person is authorized to represent
        /// the company.
        /// </summary>
        [JsonProperty("company_authorization")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("company_authorization")]
#endif
        public PersonDocumentsCompanyAuthorization CompanyAuthorization { get; set; }

        /// <summary>
        /// One or more documents showing the person’s passport page with photo and personal data.
        /// </summary>
        [JsonProperty("passport")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("passport")]
#endif
        public PersonDocumentsPassport Passport { get; set; }

        /// <summary>
        /// An identifying document showing the person's name, either a passport or local ID card.
        /// </summary>
        [JsonProperty("primary_verification")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("primary_verification")]
#endif
        public PersonDocumentsPrimaryVerification PrimaryVerification { get; set; }

        /// <summary>
        /// A document showing address, either a passport, local ID card, or utility bill from a
        /// well-known utility company.
        /// </summary>
        [JsonProperty("secondary_verification")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("secondary_verification")]
#endif
        public PersonDocumentsSecondaryVerification SecondaryVerification { get; set; }

        /// <summary>
        /// One or more documents showing the person’s visa required for living in the country where
        /// they are residing.
        /// </summary>
        [JsonProperty("visa")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("visa")]
#endif
        public PersonDocumentsVisa Visa { get; set; }
    }
}
