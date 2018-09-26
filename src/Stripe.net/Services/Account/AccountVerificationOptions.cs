namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountVerificationOptions : INestedOptions
    {
        [JsonProperty("document_back")]
        public string DocumentBackId { get; set; }

        [JsonProperty("document")]
        public string DocumentId { get; set; }
    }
}
