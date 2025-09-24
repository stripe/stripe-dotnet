// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentRecordPaymentMethodDetailsCardWallet : StripeEntity<PaymentRecordPaymentMethodDetailsCardWallet>
    {
        [JsonProperty("apple_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("apple_pay")]
#endif
        public PaymentRecordPaymentMethodDetailsCardWalletApplePay ApplePay { get; set; }

        /// <summary>
        /// (For tokenized numbers only.) The last four digits of the device account number.
        /// </summary>
        [JsonProperty("dynamic_last4")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("dynamic_last4")]
#endif
        public string DynamicLast4 { get; set; }

        [JsonProperty("google_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("google_pay")]
#endif
        public PaymentRecordPaymentMethodDetailsCardWalletGooglePay GooglePay { get; set; }

        /// <summary>
        /// The type of the card wallet, one of <c>apple_pay</c> or <c>google_pay</c>. An additional
        /// hash is included on the Wallet subhash with a name matching this value. It contains
        /// additional information specific to the card wallet type.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
