// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountLinkUseCaseAccountDashboard : StripeEntity<AccountLinkUseCaseAccountDashboard>
    {
        /// <summary>
        /// The URL to redirect to if the Account Link has expired or has already been used.
        /// Authenticate the user before generating a replacement link.
        /// </summary>
        [JsonProperty("refresh_url")]
        [STJS.JsonPropertyName("refresh_url")]
        public string RefreshUrl { get; set; }
    }
}
