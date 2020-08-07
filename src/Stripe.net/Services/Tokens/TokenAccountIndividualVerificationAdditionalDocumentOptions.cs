namespace Stripe
{
    using Newtonsoft.Json;

    public class TokenAccountIndividualVerificationAdditionalDocumentOptions : INestedOptions
    {
        [JsonProperty("back")]
        public string Back { get; set; }

        [JsonProperty("front")]
        public string Front { get; set; }
    }
}
