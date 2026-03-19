// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class TokenPersonDocumentsOptions : INestedOptions
    {
        /// <summary>
        /// One or more documents that demonstrate proof that this person is authorized to represent
        /// the company.
        /// </summary>
        [JsonProperty("company_authorization")]
        [STJS.JsonPropertyName("company_authorization")]
        public TokenPersonDocumentsCompanyAuthorizationOptions CompanyAuthorization { get; set; }

        /// <summary>
        /// One or more documents showing the person's passport page with photo and personal data.
        /// </summary>
        [JsonProperty("passport")]
        [STJS.JsonPropertyName("passport")]
        public TokenPersonDocumentsPassportOptions Passport { get; set; }

        /// <summary>
        /// One or more documents showing the person's visa required for living in the country where
        /// they are residing.
        /// </summary>
        [JsonProperty("visa")]
        [STJS.JsonPropertyName("visa")]
        public TokenPersonDocumentsVisaOptions Visa { get; set; }
    }
}
