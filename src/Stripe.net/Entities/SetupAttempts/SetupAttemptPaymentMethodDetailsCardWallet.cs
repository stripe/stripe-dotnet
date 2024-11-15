// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SetupAttemptPaymentMethodDetailsCardWallet : StripeEntity<SetupAttemptPaymentMethodDetailsCardWallet>
    {
        [JsonProperty("apple_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("apple_pay")]
#endif

        public SetupAttemptPaymentMethodDetailsCardWalletApplePay ApplePay { get; set; }

        [JsonProperty("google_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("google_pay")]
#endif

        public SetupAttemptPaymentMethodDetailsCardWalletGooglePay GooglePay { get; set; }

        /// <summary>
        /// The type of the card wallet, one of <c>apple_pay</c>, <c>google_pay</c>, or <c>link</c>.
        /// An additional hash is included on the Wallet subhash with a name matching this value. It
        /// contains additional information specific to the card wallet type.
        /// One of: <c>apple_pay</c>, <c>google_pay</c>, or <c>link</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif

        public string Type { get; set; }
    }
}
