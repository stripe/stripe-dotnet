// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CardWallets : StripeEntity<CardWallets>
    {
        [JsonProperty("apple_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("apple_pay")]
#endif
        public CardWalletsApplePay ApplePay { get; set; }

        [JsonProperty("google_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("google_pay")]
#endif
        public CardWalletsGooglePay GooglePay { get; set; }

        /// <summary>
        /// Unique identifier for a card used with digital wallets.
        /// </summary>
        [JsonProperty("primary_account_identifier")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("primary_account_identifier")]
#endif
        public string PrimaryAccountIdentifier { get; set; }
    }
}
