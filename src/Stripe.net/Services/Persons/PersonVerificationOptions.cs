namespace Stripe
{
    using Newtonsoft.Json;

    public class PersonVerificationOptions : INestedOptions
    {
        [JsonProperty("additional_document")]
        public PersonVerificationAdditionalDocumentOptions AdditionalDocument { get; set; }

        [JsonProperty("document")]
        public PersonVerificationDocumentOptions Document { get; set; }
    }
}
