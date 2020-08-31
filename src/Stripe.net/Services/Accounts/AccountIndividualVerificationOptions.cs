namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountIndividualVerificationOptions : INestedOptions
    {
        /// <summary>
        /// A document showing address, either a passport, local ID card, or utility bill from a
        /// well-known utility company.
        /// </summary>
        [JsonProperty("additional_document")]
        public AccountIndividualVerificationAdditionalDocumentOptions AdditionalDocument { get; set; }

        /// <summary>
        /// An identifying document, either a passport or local ID card.
        /// </summary>
        [JsonProperty("document")]
        public AccountIndividualVerificationDocumentOptions Document { get; set; }
    }
}
