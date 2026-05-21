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
        /// The remaining balance in the cardholder's account after the authorization, in the
        /// smallest currency unit.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// The currency of the remaining balance in the cardholder's account after the
        /// authorization.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }
    }
}
