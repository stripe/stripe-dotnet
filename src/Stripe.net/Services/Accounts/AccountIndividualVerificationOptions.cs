namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountIndividualVerificationOptions : INestedOptions
    {
        [JsonProperty("additional_document")]
        public AccountIndividualVerificationAdditionalDocumentOptions AdditionalDocument { get; set; }

        [JsonProperty("document")]
        public AccountIndividualVerificationDocumentOptions Document { get; set; }
    }
}
