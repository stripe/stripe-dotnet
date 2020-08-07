namespace Stripe
{
    using Newtonsoft.Json;

    public class TokenAccountIndividualVerificationOptions : INestedOptions
    {
        [JsonProperty("additional_document")]
        public TokenAccountIndividualVerificationAdditionalDocumentOptions AdditionalDocument { get; set; }

        [JsonProperty("document")]
        public TokenAccountIndividualVerificationDocumentOptions Document { get; set; }
    }
}
