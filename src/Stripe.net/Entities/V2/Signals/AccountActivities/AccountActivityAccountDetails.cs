// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountActivityAccountDetails : StripeEntity<AccountActivityAccountDetails>
    {
        /// <summary>
        /// The v2 account ID of the account.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// The v1 customer ID of the account, for users not yet migrated to v2/accounts.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// Inline account data to evaluate without creating a v2 account.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]
        public AccountActivityAccountDetailsData Data { get; set; }
    }
}
