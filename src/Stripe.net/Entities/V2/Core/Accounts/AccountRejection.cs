// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountRejection : StripeEntity<AccountRejection>
    {
        /// <summary>
        /// Details about the platform's rejection of the Account. Null if the platform hasn't
        /// rejected the Account.
        /// </summary>
        [JsonProperty("platform_rejection")]
        [STJS.JsonPropertyName("platform_rejection")]
        public AccountRejectionPlatformRejection PlatformRejection { get; set; }
    }
}
