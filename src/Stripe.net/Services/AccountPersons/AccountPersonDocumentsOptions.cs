// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountPersonDocumentsOptions : INestedOptions
    {
        /// <summary>
        /// One or more documents that demonstrate proof that this person is authorized to represent
        /// the company.
        /// </summary>
        [JsonProperty("company_authorization")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("company_authorization")]
#endif

        public AccountPersonDocumentsCompanyAuthorizationOptions CompanyAuthorization { get; set; }

        /// <summary>
        /// One or more documents showing the person's passport page with photo and personal data.
        /// </summary>
        [JsonProperty("passport")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("passport")]
#endif

        public AccountPersonDocumentsPassportOptions Passport { get; set; }

        /// <summary>
        /// One or more documents showing the person's visa required for living in the country where
        /// they are residing.
        /// </summary>
        [JsonProperty("visa")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("visa")]
#endif

        public AccountPersonDocumentsVisaOptions Visa { get; set; }
    }
}
