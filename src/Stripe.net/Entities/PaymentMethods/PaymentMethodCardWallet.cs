namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodCardWallet : StripeEntity<PaymentMethodCardWallet>
    {
        [JsonProperty("amex_express_checkout")]
        public PaymentMethodCardWalletAmexExpressCheckout AmexExpressCheckout { get; set; }

        [JsonProperty("apple_pay")]
        public PaymentMethodCardWalletApplePay ApplePay { get; set; }

        [JsonProperty("dynamic_last4")]
        public string DynamicLast4 { get; set; }

        [JsonProperty("google_pay")]
        public PaymentMethodCardWalletGooglePay GooglePay { get; set; }

        [JsonProperty("masterpass")]
        public PaymentMethodCardWalletMasterpass Masterpass { get; set; }

        [JsonProperty("samsung_pay")]
        public PaymentMethodCardWalletSamsungPay SamsungPay { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("visa_checkout")]
        public PaymentMethodCardWalletVisaCheckout VisaCheckout { get; set; }
    }
}
