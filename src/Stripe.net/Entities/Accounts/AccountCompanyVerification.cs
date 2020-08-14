namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountCompanyVerification : StripeEntity<AccountCompanyVerification>
    {
        [JsonProperty("document")]
        public AccountCompanyVerificationDocument Document { get; set; }
    }
}
