namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountCompanyVerificationDocumentOptions : INestedOptions
    {
        [JsonProperty("back")]
        public string Back { get; set; }

        [JsonProperty("front")]
        public string Front { get; set; }
    }
}
