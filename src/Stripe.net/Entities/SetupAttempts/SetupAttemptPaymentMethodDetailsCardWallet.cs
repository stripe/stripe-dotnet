// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupAttemptPaymentMethodDetailsCardWallet : StripeEntity<SetupAttemptPaymentMethodDetailsCardWallet>
    {
        [JsonProperty("apple_pay")]
        public SetupAttemptPaymentMethodDetailsCardWalletApplePay ApplePay { get; set; }

        [JsonProperty("google_pay")]
        public SetupAttemptPaymentMethodDetailsCardWalletGooglePay GooglePay { get; set; }

        /// <summary>
        /// The type of the card wallet, one of <c>apple_pay</c>, <c>google_pay</c>, or <c>link</c>.
        /// An additional hash is included on the Wallet subhash with a name matching this value. It
        /// contains additional information specific to the card wallet type.
        /// One of: <c>apple_pay</c>, <c>google_pay</c>, or <c>link</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
