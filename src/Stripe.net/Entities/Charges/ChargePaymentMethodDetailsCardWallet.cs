// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsCardWallet : StripeEntity<ChargePaymentMethodDetailsCardWallet>
    {
        [JsonProperty("amex_express_checkout")]
        public ChargePaymentMethodDetailsCardWalletAmexExpressCheckout AmexExpressCheckout { get; set; }

        [JsonProperty("apple_pay")]
        public ChargePaymentMethodDetailsCardWalletApplePay ApplePay { get; set; }

        /// <summary>
        /// (For tokenized numbers only.) The last four digits of the device account number.
        /// </summary>
        [JsonProperty("dynamic_last4")]
        public string DynamicLast4 { get; set; }

        [JsonProperty("google_pay")]
        public ChargePaymentMethodDetailsCardWalletGooglePay GooglePay { get; set; }

        [JsonProperty("link")]
        public ChargePaymentMethodDetailsCardWalletLink Link { get; set; }

        [JsonProperty("masterpass")]
        public ChargePaymentMethodDetailsCardWalletMasterpass Masterpass { get; set; }

        [JsonProperty("samsung_pay")]
        public ChargePaymentMethodDetailsCardWalletSamsungPay SamsungPay { get; set; }

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
        public ChargePaymentMethodDetailsCardWalletVisaCheckout VisaCheckout { get; set; }
    }
}
