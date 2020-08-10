namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountCompanyVerificationOptions : INestedOptions
    {
        [JsonProperty("document")]
        public AccountCompanyVerificationDocumentOptions Document { get; set; }
    }
}
