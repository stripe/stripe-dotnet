// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class CardWallets : StripeEntity<CardWallets>
    {
        [JsonProperty("apple_pay")]
        public CardWalletsApplePay ApplePay { get; set; }

        [JsonProperty("google_pay")]
        public CardWalletsGooglePay GooglePay { get; set; }

        /// <summary>
        /// Unique identifier for a card used with digital wallets.
        /// </summary>
        [JsonProperty("primary_account_identifier")]
        public string PrimaryAccountIdentifier { get; set; }
    }
}
