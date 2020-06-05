namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ChargePaymentMethodDetailsCardWallet : StripeEntity<ChargePaymentMethodDetailsCardWallet>
    {
        [JsonProperty("amex_express_checkout")]
        public ChargePaymentMethodDetailsCardWalletAmexExpressCheckout AmexExpressCheckout { get; set; }

        [JsonProperty("apple_pay")]
        public ChargePaymentMethodDetailsCardWalletApplePay ApplePay { get; set; }

        [JsonProperty("dynamic_last4")]
        public string DynamicLast4 { get; set; }

        [JsonProperty("google_pay")]
        public ChargePaymentMethodDetailsCardWalletGooglePay GooglePay { get; set; }

        [JsonProperty("masterpass")]
        public ChargePaymentMethodDetailsCardWalletMasterpass Masterpass { get; set; }

        [JsonProperty("samsung_pay")]
        public ChargePaymentMethodDetailsCardWalletSamsungPay SamsungPay { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("visa_checkout")]
        public ChargePaymentMethodDetailsCardWalletVisaCheckout VisaCheckout { get; set; }
    }
}
