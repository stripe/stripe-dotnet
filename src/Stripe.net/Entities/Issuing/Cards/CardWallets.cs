// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CardWallets : StripeEntity<CardWallets>
    {
        [JsonProperty("apple_pay")]
        [STJS.JsonPropertyName("apple_pay")]
        public CardWalletsApplePay ApplePay { get; set; }

        [JsonProperty("google_pay")]
        [STJS.JsonPropertyName("google_pay")]
        public CardWalletsGooglePay GooglePay { get; set; }

        /// <summary>
        /// Unique identifier for a card used with digital wallets.
        /// </summary>
        [JsonProperty("primary_account_identifier")]
        [STJS.JsonPropertyName("primary_account_identifier")]
        public string PrimaryAccountIdentifier { get; set; }
    }
}
