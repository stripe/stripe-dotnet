// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Accounts
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PersonCreateDocumentsOptions : INestedOptions
    {
        /// <summary>
        /// One or more documents that demonstrate proof that this person is authorized to represent
        /// the company.
        /// </summary>
        [JsonProperty("company_authorization")]
        [STJS.JsonPropertyName("company_authorization")]
        public PersonCreateDocumentsCompanyAuthorizationOptions CompanyAuthorization { get; set; }

        /// <summary>
        /// One or more documents showing the person’s passport page with photo and personal data.
        /// </summary>
        [JsonProperty("passport")]
        [STJS.JsonPropertyName("passport")]
        public PersonCreateDocumentsPassportOptions Passport { get; set; }

        /// <summary>
        /// An identifying document showing the person's name, either a passport or local ID card.
        /// </summary>
        [JsonProperty("primary_verification")]
        [STJS.JsonPropertyName("primary_verification")]
        public PersonCreateDocumentsPrimaryVerificationOptions PrimaryVerification { get; set; }

        /// <summary>
        /// A document showing address, either a passport, local ID card, or utility bill from a
        /// well-known utility company.
        /// </summary>
        [JsonProperty("secondary_verification")]
        [STJS.JsonPropertyName("secondary_verification")]
        public PersonCreateDocumentsSecondaryVerificationOptions SecondaryVerification { get; set; }

        /// <summary>
        /// One or more documents showing the person’s visa required for living in the country where
        /// they are residing.
        /// </summary>
        [JsonProperty("visa")]
        [STJS.JsonPropertyName("visa")]
        public PersonCreateDocumentsVisaOptions Visa { get; set; }
    }
}
