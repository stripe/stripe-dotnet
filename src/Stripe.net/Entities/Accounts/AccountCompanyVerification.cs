namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountCompanyVerification : StripeEntity<AccountCompanyVerification>
    {
        /// <summary>
        /// A document for the company.
        /// </summary>
        [JsonProperty("document")]
        public AccountCompanyVerificationDocument Document { get; set; }
    }
}
