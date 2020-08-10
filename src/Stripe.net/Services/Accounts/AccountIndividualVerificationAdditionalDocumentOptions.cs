namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountIndividualVerificationAdditionalDocumentOptions : INestedOptions
    {
        [JsonProperty("back")]
        public string Back { get; set; }

        [JsonProperty("front")]
        public string Front { get; set; }
    }
}
