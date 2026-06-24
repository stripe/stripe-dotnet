// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthorizationBalanceResponse : StripeEntity<AuthorizationBalanceResponse>
    {
        /// <summary>
        /// The cardholder account type affected by this authorization.
        /// One of: <c>checking</c>, <c>credit</c>, <c>default</c>, <c>other</c>, <c>savings</c>, or
        /// <c>universal</c>.
        /// </summary>
        [JsonProperty("account_type")]
        [STJS.JsonPropertyName("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// The available balance or credit limit in the cardholder's account after the
        /// authorization, in the smallest currency unit.
        /// </summary>
        [JsonProperty("available_balance")]
        [STJS.JsonPropertyName("available_balance")]
        public long AvailableBalance { get; set; }

        /// <summary>
        /// The currency of the remaining balances in the cardholder's account after the
        /// authorization.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The current ledger balance or remaining credit amount in the cardholder's account after
        /// the authorization, in the smallest currency unit.
        /// </summary>
        [JsonProperty("current_balance")]
        [STJS.JsonPropertyName("current_balance")]
        public long CurrentBalance { get; set; }
    }
}
