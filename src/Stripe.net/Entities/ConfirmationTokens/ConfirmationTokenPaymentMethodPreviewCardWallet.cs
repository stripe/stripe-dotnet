// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ConfirmationTokenPaymentMethodPreviewCardWallet : StripeEntity<ConfirmationTokenPaymentMethodPreviewCardWallet>
    {
        [JsonProperty("amex_express_checkout")]
        public ConfirmationTokenPaymentMethodPreviewCardWalletAmexExpressCheckout AmexExpressCheckout { get; set; }

        [JsonProperty("apple_pay")]
        public ConfirmationTokenPaymentMethodPreviewCardWalletApplePay ApplePay { get; set; }

        /// <summary>
        /// (For tokenized numbers only.) The last four digits of the device account number.
        /// </summary>
        [JsonProperty("dynamic_last4")]
        public string DynamicLast4 { get; set; }

        [JsonProperty("google_pay")]
        public ConfirmationTokenPaymentMethodPreviewCardWalletGooglePay GooglePay { get; set; }

        [JsonProperty("link")]
        public ConfirmationTokenPaymentMethodPreviewCardWalletLink Link { get; set; }

        [JsonProperty("masterpass")]
        public ConfirmationTokenPaymentMethodPreviewCardWalletMasterpass Masterpass { get; set; }

        [JsonProperty("samsung_pay")]
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
        public string Type { get; set; }

        [JsonProperty("visa_checkout")]
        public ConfirmationTokenPaymentMethodPreviewCardWalletVisaCheckout VisaCheckout { get; set; }
    }
}
