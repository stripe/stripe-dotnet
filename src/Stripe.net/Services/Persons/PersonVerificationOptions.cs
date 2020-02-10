namespace Stripe
{
    using Newtonsoft.Json;

    public class PersonVerificationOptions : INestedOptions
    {
        [JsonProperty("additional_document")]
        public PersonVerificationDocumentOptions AdditionalDocument { get; set; }

        [JsonProperty("document")]
        public PersonVerificationDocumentOptions Document { get; set; }
    }
}
