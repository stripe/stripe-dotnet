namespace Stripe
{
    using Newtonsoft.Json;

    public class TokenAccountCompanyVerificationOptions : INestedOptions
    {
        [JsonProperty("document")]
        public TokenAccountCompanyVerificationDocumentOptions Document { get; set; }
    }
}
