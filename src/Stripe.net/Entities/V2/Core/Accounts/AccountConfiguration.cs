// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountConfiguration : StripeEntity<AccountConfiguration>
    {
        /// <summary>
        /// The Customer Configuration allows the Account to be used in inbound payment flows.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public AccountConfigurationCustomer Customer { get; set; }

        /// <summary>
        /// The Merchant Configuration allows the Account to make charges.
        /// </summary>
        [JsonProperty("merchant")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("merchant")]
#endif
        public AccountConfigurationMerchant Merchant { get; set; }

        /// <summary>
        /// The Recipient Configuration allows the Account to receive funds.
        /// </summary>
        [JsonProperty("recipient")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("recipient")]
#endif
        public AccountConfigurationRecipient Recipient { get; set; }
    }
}
