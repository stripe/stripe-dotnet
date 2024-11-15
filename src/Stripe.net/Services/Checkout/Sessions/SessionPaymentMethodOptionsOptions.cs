// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionPaymentMethodOptionsOptions : INestedOptions
    {
        /// <summary>
        /// contains details about the ACSS Debit payment method options.
        /// </summary>
        [JsonProperty("acss_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("acss_debit")]
#endif

        public SessionPaymentMethodOptionsAcssDebitOptions AcssDebit { get; set; }

        /// <summary>
        /// contains details about the Affirm payment method options.
        /// </summary>
        [JsonProperty("affirm")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("affirm")]
#endif

        public SessionPaymentMethodOptionsAffirmOptions Affirm { get; set; }

        /// <summary>
        /// contains details about the Afterpay Clearpay payment method options.
        /// </summary>
        [JsonProperty("afterpay_clearpay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("afterpay_clearpay")]
#endif

        public SessionPaymentMethodOptionsAfterpayClearpayOptions AfterpayClearpay { get; set; }

        /// <summary>
        /// contains details about the Alipay payment method options.
        /// </summary>
        [JsonProperty("alipay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("alipay")]
#endif

        public SessionPaymentMethodOptionsAlipayOptions Alipay { get; set; }

        /// <summary>
        /// contains details about the AmazonPay payment method options.
        /// </summary>
        [JsonProperty("amazon_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amazon_pay")]
#endif

        public SessionPaymentMethodOptionsAmazonPayOptions AmazonPay { get; set; }

        /// <summary>
        /// contains details about the AU Becs Debit payment method options.
        /// </summary>
        [JsonProperty("au_becs_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("au_becs_debit")]
#endif

        public SessionPaymentMethodOptionsAuBecsDebitOptions AuBecsDebit { get; set; }

        /// <summary>
        /// contains details about the Bacs Debit payment method options.
        /// </summary>
        [JsonProperty("bacs_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bacs_debit")]
#endif

        public SessionPaymentMethodOptionsBacsDebitOptions BacsDebit { get; set; }

        /// <summary>
        /// contains details about the Bancontact payment method options.
        /// </summary>
        [JsonProperty("bancontact")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bancontact")]
#endif

        public SessionPaymentMethodOptionsBancontactOptions Bancontact { get; set; }

        /// <summary>
        /// contains details about the Boleto payment method options.
        /// </summary>
        [JsonProperty("boleto")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("boleto")]
#endif

        public SessionPaymentMethodOptionsBoletoOptions Boleto { get; set; }

        /// <summary>
        /// contains details about the Card payment method options.
        /// </summary>
        [JsonProperty("card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card")]
#endif

        public SessionPaymentMethodOptionsCardOptions Card { get; set; }

        /// <summary>
        /// contains details about the Cashapp Pay payment method options.
        /// </summary>
        [JsonProperty("cashapp")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cashapp")]
#endif

        public SessionPaymentMethodOptionsCashappOptions Cashapp { get; set; }

        /// <summary>
        /// contains details about the Customer Balance payment method options.
        /// </summary>
        [JsonProperty("customer_balance")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_balance")]
#endif

        public SessionPaymentMethodOptionsCustomerBalanceOptions CustomerBalance { get; set; }

        /// <summary>
        /// contains details about the EPS payment method options.
        /// </summary>
        [JsonProperty("eps")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("eps")]
#endif

        public SessionPaymentMethodOptionsEpsOptions Eps { get; set; }

        /// <summary>
        /// contains details about the FPX payment method options.
        /// </summary>
        [JsonProperty("fpx")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fpx")]
#endif

        public SessionPaymentMethodOptionsFpxOptions Fpx { get; set; }

        /// <summary>
        /// contains details about the Giropay payment method options.
        /// </summary>
        [JsonProperty("giropay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("giropay")]
#endif

        public SessionPaymentMethodOptionsGiropayOptions Giropay { get; set; }

        /// <summary>
        /// contains details about the Grabpay payment method options.
        /// </summary>
        [JsonProperty("grabpay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("grabpay")]
#endif

        public SessionPaymentMethodOptionsGrabpayOptions Grabpay { get; set; }

        /// <summary>
        /// contains details about the Ideal payment method options.
        /// </summary>
        [JsonProperty("ideal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ideal")]
#endif

        public SessionPaymentMethodOptionsIdealOptions Ideal { get; set; }

        /// <summary>
        /// contains details about the Kakao Pay payment method options.
        /// </summary>
        [JsonProperty("kakao_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("kakao_pay")]
#endif

        public SessionPaymentMethodOptionsKakaoPayOptions KakaoPay { get; set; }

        /// <summary>
        /// contains details about the Klarna payment method options.
        /// </summary>
        [JsonProperty("klarna")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("klarna")]
#endif

        public SessionPaymentMethodOptionsKlarnaOptions Klarna { get; set; }

        /// <summary>
        /// contains details about the Konbini payment method options.
        /// </summary>
        [JsonProperty("konbini")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("konbini")]
#endif

        public SessionPaymentMethodOptionsKonbiniOptions Konbini { get; set; }

        /// <summary>
        /// contains details about the Korean card payment method options.
        /// </summary>
        [JsonProperty("kr_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("kr_card")]
#endif

        public SessionPaymentMethodOptionsKrCardOptions KrCard { get; set; }

        /// <summary>
        /// contains details about the Link payment method options.
        /// </summary>
        [JsonProperty("link")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("link")]
#endif

        public SessionPaymentMethodOptionsLinkOptions Link { get; set; }

        /// <summary>
        /// contains details about the Mobilepay payment method options.
        /// </summary>
        [JsonProperty("mobilepay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mobilepay")]
#endif

        public SessionPaymentMethodOptionsMobilepayOptions Mobilepay { get; set; }

        /// <summary>
        /// contains details about the Multibanco payment method options.
        /// </summary>
        [JsonProperty("multibanco")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("multibanco")]
#endif

        public SessionPaymentMethodOptionsMultibancoOptions Multibanco { get; set; }

        /// <summary>
        /// contains details about the Kakao Pay payment method options.
        /// </summary>
        [JsonProperty("naver_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("naver_pay")]
#endif

        public SessionPaymentMethodOptionsNaverPayOptions NaverPay { get; set; }

        /// <summary>
        /// contains details about the OXXO payment method options.
        /// </summary>
        [JsonProperty("oxxo")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("oxxo")]
#endif

        public SessionPaymentMethodOptionsOxxoOptions Oxxo { get; set; }

        /// <summary>
        /// contains details about the P24 payment method options.
        /// </summary>
        [JsonProperty("p24")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("p24")]
#endif

        public SessionPaymentMethodOptionsP24Options P24 { get; set; }

        /// <summary>
        /// contains details about the PAYCO payment method options.
        /// </summary>
        [JsonProperty("payco")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payco")]
#endif

        public SessionPaymentMethodOptionsPaycoOptions Payco { get; set; }

        /// <summary>
        /// contains details about the PayNow payment method options.
        /// </summary>
        [JsonProperty("paynow")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paynow")]
#endif

        public SessionPaymentMethodOptionsPaynowOptions Paynow { get; set; }

        /// <summary>
        /// contains details about the PayPal payment method options.
        /// </summary>
        [JsonProperty("paypal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paypal")]
#endif

        public SessionPaymentMethodOptionsPaypalOptions Paypal { get; set; }

        /// <summary>
        /// contains details about the Pix payment method options.
        /// </summary>
        [JsonProperty("pix")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pix")]
#endif

        public SessionPaymentMethodOptionsPixOptions Pix { get; set; }

        /// <summary>
        /// contains details about the RevolutPay payment method options.
        /// </summary>
        [JsonProperty("revolut_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("revolut_pay")]
#endif

        public SessionPaymentMethodOptionsRevolutPayOptions RevolutPay { get; set; }

        /// <summary>
        /// contains details about the Samsung Pay payment method options.
        /// </summary>
        [JsonProperty("samsung_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("samsung_pay")]
#endif

        public SessionPaymentMethodOptionsSamsungPayOptions SamsungPay { get; set; }

        /// <summary>
        /// contains details about the Sepa Debit payment method options.
        /// </summary>
        [JsonProperty("sepa_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sepa_debit")]
#endif

        public SessionPaymentMethodOptionsSepaDebitOptions SepaDebit { get; set; }

        /// <summary>
        /// contains details about the Sofort payment method options.
        /// </summary>
        [JsonProperty("sofort")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sofort")]
#endif

        public SessionPaymentMethodOptionsSofortOptions Sofort { get; set; }

        /// <summary>
        /// contains details about the Swish payment method options.
        /// </summary>
        [JsonProperty("swish")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("swish")]
#endif

        public SessionPaymentMethodOptionsSwishOptions Swish { get; set; }

        /// <summary>
        /// contains details about the Us Bank Account payment method options.
        /// </summary>
        [JsonProperty("us_bank_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("us_bank_account")]
#endif

        public SessionPaymentMethodOptionsUsBankAccountOptions UsBankAccount { get; set; }

        /// <summary>
        /// contains details about the WeChat Pay payment method options.
        /// </summary>
        [JsonProperty("wechat_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("wechat_pay")]
#endif

        public SessionPaymentMethodOptionsWechatPayOptions WechatPay { get; set; }
    }
}
