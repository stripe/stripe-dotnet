namespace Stripe
{
    using Newtonsoft.Json;

    public class TokenPersonVerificationOptions : INestedOptions
    {
        [JsonProperty("additional_document")]
        public TokenPersonVerificationDocumentOptions AdditionalDocument { get; set; }

        [JsonProperty("document")]
        public TokenPersonVerificationDocumentOptions Document { get; set; }
    }
}
