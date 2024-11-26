// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountIndividualVerificationOptions : INestedOptions
    {
        /// <summary>
        /// A document showing address, either a passport, local ID card, or utility bill from a
        /// well-known utility company.
        /// </summary>
        [JsonProperty("additional_document")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("additional_document")]
#endif
        public AccountIndividualVerificationAdditionalDocumentOptions AdditionalDocument { get; set; }

        /// <summary>
        /// An identifying document, either a passport or local ID card.
        /// </summary>
        [JsonProperty("document")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("document")]
#endif
        public AccountIndividualVerificationDocumentOptions Document { get; set; }
    }
}
