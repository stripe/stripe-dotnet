namespace Stripe
{
#if USE_SYSTEM_TEXT_JSON
    using System.Text.Json.Serialization;
#else
    using Newtonsoft.Json;
#endif

    public class AccountCompanyVerification : StripeEntity<AccountCompanyVerification>
    {
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("document")]
#else
        [JsonProperty("document")]
#endif
        public AccountCompanyVerificationDocument Document { get; set; }
    }
}
