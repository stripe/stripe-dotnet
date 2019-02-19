namespace Stripe
{
    using Newtonsoft.Json;

    public class PersonVerificationOptions : INestedOptions
    {
        [JsonProperty("document")]
        public PersonVerificationDocumentOptions Document { get; set; }
    }
}
