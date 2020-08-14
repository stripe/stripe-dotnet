namespace Stripe
{
    using Newtonsoft.Json;

    public class TokenAccountIndividualVerificationOptions : INestedOptions
    {
        /// <summary>
        /// A document showing address, either a passport, local ID card, or utility bill from a
        /// well-known utility company.
        /// </summary>
        [JsonProperty("additional_document")]
        public TokenAccountIndividualVerificationAdditionalDocumentOptions AdditionalDocument { get; set; }

        /// <summary>
        /// An identifying document, either a passport or local ID card.
        /// </summary>
        [JsonProperty("document")]
        public TokenAccountIndividualVerificationDocumentOptions Document { get; set; }
    }
}
