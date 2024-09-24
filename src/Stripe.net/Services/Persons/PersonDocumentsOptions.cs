namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    [Obsolete("Use AccountPersonDocumentsOptions instead.")]
    public class PersonDocumentsOptions : INestedOptions
    {
        /// <summary>
        /// One or more documents that demonstrate proof that this person is authorized to represent
        /// the company.
        /// </summary>
        [JsonProperty("company_authorization")]
        public PersonDocumentsCompanyAuthorizationOptions CompanyAuthorization { get; set; }

        /// <summary>
        /// One or more documents showing the person's passport page with photo and personal data.
        /// </summary>
        [JsonProperty("passport")]
        public PersonDocumentsPassportOptions Passport { get; set; }

        /// <summary>
        /// One or more documents showing the person's visa required for living in the country where
        /// they are residing.
        /// </summary>
        [JsonProperty("visa")]
        public PersonDocumentsVisaOptions Visa { get; set; }
    }
}
