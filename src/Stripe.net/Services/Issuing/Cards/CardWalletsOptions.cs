// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CardWalletsOptions : INestedOptions
    {
        /// <summary>
        /// Filter cards by Apple Pay wallet details.
        /// </summary>
        [JsonProperty("apple_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("apple_pay")]
#endif
        public CardWalletsApplePayOptions ApplePay { get; set; }

        /// <summary>
        /// Filter cards by Google Pay wallet details.
        /// </summary>
        [JsonProperty("google_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("google_pay")]
#endif
        public CardWalletsGooglePayOptions GooglePay { get; set; }
    }
}
