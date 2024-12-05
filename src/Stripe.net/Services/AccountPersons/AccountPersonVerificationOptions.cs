// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountPersonVerificationOptions : INestedOptions
    {
        /// <summary>
        /// A document showing address, either a passport, local ID card, or utility bill from a
        /// well-known utility company.
        /// </summary>
        [JsonProperty("additional_document")]
        public AccountPersonVerificationAdditionalDocumentOptions AdditionalDocument { get; set; }

        /// <summary>
        /// An identifying document, either a passport or local ID card.
        /// </summary>
        [JsonProperty("document")]
        public AccountPersonVerificationDocumentOptions Document { get; set; }
    }
}
