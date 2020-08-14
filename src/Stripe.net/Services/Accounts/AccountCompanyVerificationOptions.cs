namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountCompanyVerificationOptions : INestedOptions
    {
        /// <summary>
        /// A document verifying the business.
        /// </summary>
        [JsonProperty("document")]
        public AccountCompanyVerificationDocumentOptions Document { get; set; }
    }
}
