namespace Stripe
{
    using Newtonsoft.Json;

    public class PersonVerificationDocumentOptions : INestedOptions
    {
        [JsonProperty("back")]
        public string BackFileId { get; set; }

        [JsonProperty("front")]
        public string FrontFileId { get; set; }
    }
}
