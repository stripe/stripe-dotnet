// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountCompanyVerification : StripeEntity<AccountCompanyVerification>
    {
        [JsonProperty("document")]
        [STJS.JsonPropertyName("document")]
        public AccountCompanyVerificationDocument Document { get; set; }
    }
}
