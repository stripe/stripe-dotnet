// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfirmationTokenPaymentMethodPreviewCardWallet : StripeEntity<ConfirmationTokenPaymentMethodPreviewCardWallet>
    {
        [JsonProperty("amex_express_checkout")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amex_express_checkout")]
#endif

        public ConfirmationTokenPaymentMethodPreviewCardWalletAmexExpressCheckout AmexExpressCheckout { get; set; }

        [JsonProperty("apple_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("apple_pay")]
#endif

        public ConfirmationTokenPaymentMethodPreviewCardWalletApplePay ApplePay { get; set; }

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

        public ConfirmationTokenPaymentMethodPreviewCardWalletGooglePay GooglePay { get; set; }

        [JsonProperty("link")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("link")]
#endif

        public ConfirmationTokenPaymentMethodPreviewCardWalletLink Link { get; set; }

        [JsonProperty("masterpass")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("masterpass")]
#endif

        public ConfirmationTokenPaymentMethodPreviewCardWalletMasterpass Masterpass { get; set; }

        [JsonProperty("samsung_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("samsung_pay")]
#endif

        public ConfirmationTokenPaymentMethodPreviewCardWalletSamsungPay SamsungPay { get; set; }

        /// <summary>
        /// The type of the card wallet, one of <c>amex_express_checkout</c>, <c>apple_pay</c>,
        /// <c>google_pay</c>, <c>masterpass</c>, <c>samsung_pay</c>, <c>visa_checkout</c>, or
        /// <c>link</c>. An additional hash is included on the Wallet subhash with a name matching
        /// this value. It contains additional information specific to the card wallet type.
        /// One of: <c>amex_express_checkout</c>, <c>apple_pay</c>, <c>google_pay</c>, <c>link</c>,
        /// <c>masterpass</c>, <c>samsung_pay</c>, or <c>visa_checkout</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif

        public string Type { get; set; }

        [JsonProperty("visa_checkout")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("visa_checkout")]
#endif

        public ConfirmationTokenPaymentMethodPreviewCardWalletVisaCheckout VisaCheckout { get; set; }
    }
}
