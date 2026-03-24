// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CardWalletsOptions : INestedOptions
    {
        /// <summary>
        /// Filter cards by Apple Pay wallet details.
        /// </summary>
        [JsonProperty("apple_pay")]
        [STJS.JsonPropertyName("apple_pay")]
        public CardWalletsApplePayOptions ApplePay { get; set; }

        /// <summary>
        /// Filter cards by Google Pay wallet details.
        /// </summary>
        [JsonProperty("google_pay")]
        [STJS.JsonPropertyName("google_pay")]
        public CardWalletsGooglePayOptions GooglePay { get; set; }
    }
}
