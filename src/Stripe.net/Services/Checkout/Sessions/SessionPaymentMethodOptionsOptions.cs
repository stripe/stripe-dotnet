// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionPaymentMethodOptionsOptions : INestedOptions
    {
        /// <summary>
        /// contains details about the ACSS Debit payment method options.
        /// </summary>
        [JsonProperty("acss_debit")]
        public SessionPaymentMethodOptionsAcssDebitOptions AcssDebit { get; set; }

        /// <summary>
        /// contains details about the Alipay payment method options.
        /// </summary>
        [JsonProperty("alipay")]
        public SessionPaymentMethodOptionsAlipayOptions Alipay { get; set; }

        /// <summary>
        /// contains details about the Boleto payment method options.
        /// </summary>
        [JsonProperty("boleto")]
        public SessionPaymentMethodOptionsBoletoOptions Boleto { get; set; }

        /// <summary>
        /// contains details about the Konbini payment method options.
        /// </summary>
        [JsonProperty("konbini")]
        public SessionPaymentMethodOptionsKonbiniOptions Konbini { get; set; }

        /// <summary>
        /// contains details about the OXXO payment method options.
        /// </summary>
        [JsonProperty("oxxo")]
        public SessionPaymentMethodOptionsOxxoOptions Oxxo { get; set; }

        /// <summary>
        /// contains details about the Us Bank Account payment method options.
        /// </summary>
        [JsonProperty("us_bank_account")]
        public SessionPaymentMethodOptionsUsBankAccountOptions UsBankAccount { get; set; }

        /// <summary>
        /// contains details about the WeChat Pay payment method options.
        /// </summary>
        [JsonProperty("wechat_pay")]
        public SessionPaymentMethodOptionsWechatPayOptions WechatPay { get; set; }
    }
}
