// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountCompanyVerification : StripeEntity<AccountCompanyVerification>
    {
        [JsonProperty("document")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("document")]
#endif
        public AccountCompanyVerificationDocument Document { get; set; }
    }
}
