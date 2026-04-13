// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionPaymentMethodOptionsOptions : INestedOptions
    {
        /// <summary>
        /// contains details about the ACSS Debit payment method options. You can't set this
        /// parameter if <c>ui_mode</c> is <c>custom</c>.
        /// </summary>
        [JsonProperty("acss_debit")]
        [STJS.JsonPropertyName("acss_debit")]
        public SessionPaymentMethodOptionsAcssDebitOptions AcssDebit { get; set; }

        /// <summary>
        /// contains details about the Affirm payment method options.
        /// </summary>
        [JsonProperty("affirm")]
        [STJS.JsonPropertyName("affirm")]
        public SessionPaymentMethodOptionsAffirmOptions Affirm { get; set; }

        /// <summary>
        /// contains details about the Afterpay Clearpay payment method options.
        /// </summary>
        [JsonProperty("afterpay_clearpay")]
        [STJS.JsonPropertyName("afterpay_clearpay")]
        public SessionPaymentMethodOptionsAfterpayClearpayOptions AfterpayClearpay { get; set; }

        /// <summary>
        /// contains details about the Alipay payment method options.
        /// </summary>
        [JsonProperty("alipay")]
        [STJS.JsonPropertyName("alipay")]
        public SessionPaymentMethodOptionsAlipayOptions Alipay { get; set; }

        /// <summary>
        /// contains details about the Alma payment method options.
        /// </summary>
        [JsonProperty("alma")]
        [STJS.JsonPropertyName("alma")]
        public SessionPaymentMethodOptionsAlmaOptions Alma { get; set; }

        /// <summary>
        /// contains details about the AmazonPay payment method options.
        /// </summary>
        [JsonProperty("amazon_pay")]
        [STJS.JsonPropertyName("amazon_pay")]
        public SessionPaymentMethodOptionsAmazonPayOptions AmazonPay { get; set; }

        /// <summary>
        /// contains details about the AU Becs Debit payment method options.
        /// </summary>
        [JsonProperty("au_becs_debit")]
        [STJS.JsonPropertyName("au_becs_debit")]
        public SessionPaymentMethodOptionsAuBecsDebitOptions AuBecsDebit { get; set; }

        /// <summary>
        /// contains details about the Bacs Debit payment method options.
        /// </summary>
        [JsonProperty("bacs_debit")]
        [STJS.JsonPropertyName("bacs_debit")]
        public SessionPaymentMethodOptionsBacsDebitOptions BacsDebit { get; set; }

        /// <summary>
        /// contains details about the Bancontact payment method options.
        /// </summary>
        [JsonProperty("bancontact")]
        [STJS.JsonPropertyName("bancontact")]
        public SessionPaymentMethodOptionsBancontactOptions Bancontact { get; set; }

        /// <summary>
        /// contains details about the Billie payment method options.
        /// </summary>
        [JsonProperty("billie")]
        [STJS.JsonPropertyName("billie")]
        public SessionPaymentMethodOptionsBillieOptions Billie { get; set; }

        /// <summary>
        /// contains details about the Boleto payment method options.
        /// </summary>
        [JsonProperty("boleto")]
        [STJS.JsonPropertyName("boleto")]
        public SessionPaymentMethodOptionsBoletoOptions Boleto { get; set; }

        /// <summary>
        /// contains details about the Card payment method options.
        /// </summary>
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public SessionPaymentMethodOptionsCardOptions Card { get; set; }

        /// <summary>
        /// contains details about the Cashapp Pay payment method options.
        /// </summary>
        [JsonProperty("cashapp")]
        [STJS.JsonPropertyName("cashapp")]
        public SessionPaymentMethodOptionsCashappOptions Cashapp { get; set; }

        /// <summary>
        /// contains details about the Crypto payment method options.
        /// </summary>
        [JsonProperty("crypto")]
        [STJS.JsonPropertyName("crypto")]
        public SessionPaymentMethodOptionsCryptoOptions Crypto { get; set; }

        /// <summary>
        /// contains details about the Customer Balance payment method options.
        /// </summary>
        [JsonProperty("customer_balance")]
        [STJS.JsonPropertyName("customer_balance")]
        public SessionPaymentMethodOptionsCustomerBalanceOptions CustomerBalance { get; set; }

        /// <summary>
        /// contains details about the DemoPay payment method options.
        /// </summary>
        [JsonProperty("demo_pay")]
        [STJS.JsonPropertyName("demo_pay")]
        public SessionPaymentMethodOptionsDemoPayOptions DemoPay { get; set; }

        /// <summary>
        /// contains details about the EPS payment method options.
        /// </summary>
        [JsonProperty("eps")]
        [STJS.JsonPropertyName("eps")]
        public SessionPaymentMethodOptionsEpsOptions Eps { get; set; }

        /// <summary>
        /// contains details about the FPX payment method options.
        /// </summary>
        [JsonProperty("fpx")]
        [STJS.JsonPropertyName("fpx")]
        public SessionPaymentMethodOptionsFpxOptions Fpx { get; set; }

        /// <summary>
        /// contains details about the Giropay payment method options.
        /// </summary>
        [JsonProperty("giropay")]
        [STJS.JsonPropertyName("giropay")]
        public SessionPaymentMethodOptionsGiropayOptions Giropay { get; set; }

        /// <summary>
        /// contains details about the Grabpay payment method options.
        /// </summary>
        [JsonProperty("grabpay")]
        [STJS.JsonPropertyName("grabpay")]
        public SessionPaymentMethodOptionsGrabpayOptions Grabpay { get; set; }

        /// <summary>
        /// contains details about the Ideal payment method options.
        /// </summary>
        [JsonProperty("ideal")]
        [STJS.JsonPropertyName("ideal")]
        public SessionPaymentMethodOptionsIdealOptions Ideal { get; set; }

        /// <summary>
        /// contains details about the Kakao Pay payment method options.
        /// </summary>
        [JsonProperty("kakao_pay")]
        [STJS.JsonPropertyName("kakao_pay")]
        public SessionPaymentMethodOptionsKakaoPayOptions KakaoPay { get; set; }

        /// <summary>
        /// contains details about the Klarna payment method options.
        /// </summary>
        [JsonProperty("klarna")]
        [STJS.JsonPropertyName("klarna")]
        public SessionPaymentMethodOptionsKlarnaOptions Klarna { get; set; }

        /// <summary>
        /// contains details about the Konbini payment method options.
        /// </summary>
        [JsonProperty("konbini")]
        [STJS.JsonPropertyName("konbini")]
        public SessionPaymentMethodOptionsKonbiniOptions Konbini { get; set; }

        /// <summary>
        /// contains details about the Korean card payment method options.
        /// </summary>
        [JsonProperty("kr_card")]
        [STJS.JsonPropertyName("kr_card")]
        public SessionPaymentMethodOptionsKrCardOptions KrCard { get; set; }

        /// <summary>
        /// contains details about the Link payment method options.
        /// </summary>
        [JsonProperty("link")]
        [STJS.JsonPropertyName("link")]
        public SessionPaymentMethodOptionsLinkOptions Link { get; set; }

        /// <summary>
        /// contains details about the Mobilepay payment method options.
        /// </summary>
        [JsonProperty("mobilepay")]
        [STJS.JsonPropertyName("mobilepay")]
        public SessionPaymentMethodOptionsMobilepayOptions Mobilepay { get; set; }

        /// <summary>
        /// contains details about the Multibanco payment method options.
        /// </summary>
        [JsonProperty("multibanco")]
        [STJS.JsonPropertyName("multibanco")]
        public SessionPaymentMethodOptionsMultibancoOptions Multibanco { get; set; }

        /// <summary>
        /// contains details about the Naver Pay payment method options.
        /// </summary>
        [JsonProperty("naver_pay")]
        [STJS.JsonPropertyName("naver_pay")]
        public SessionPaymentMethodOptionsNaverPayOptions NaverPay { get; set; }

        /// <summary>
        /// contains details about the OXXO payment method options.
        /// </summary>
        [JsonProperty("oxxo")]
        [STJS.JsonPropertyName("oxxo")]
        public SessionPaymentMethodOptionsOxxoOptions Oxxo { get; set; }

        /// <summary>
        /// contains details about the P24 payment method options.
        /// </summary>
        [JsonProperty("p24")]
        [STJS.JsonPropertyName("p24")]
        public SessionPaymentMethodOptionsP24Options P24 { get; set; }

        /// <summary>
        /// contains details about the Pay By Bank payment method options.
        /// </summary>
        [JsonProperty("pay_by_bank")]
        [STJS.JsonPropertyName("pay_by_bank")]
        public SessionPaymentMethodOptionsPayByBankOptions PayByBank { get; set; }

        /// <summary>
        /// contains details about the PAYCO payment method options.
        /// </summary>
        [JsonProperty("payco")]
        [STJS.JsonPropertyName("payco")]
        public SessionPaymentMethodOptionsPaycoOptions Payco { get; set; }

        /// <summary>
        /// contains details about the PayNow payment method options.
        /// </summary>
        [JsonProperty("paynow")]
        [STJS.JsonPropertyName("paynow")]
        public SessionPaymentMethodOptionsPaynowOptions Paynow { get; set; }

        /// <summary>
        /// contains details about the PayPal payment method options.
        /// </summary>
        [JsonProperty("paypal")]
        [STJS.JsonPropertyName("paypal")]
        public SessionPaymentMethodOptionsPaypalOptions Paypal { get; set; }

        /// <summary>
        /// contains details about the PayTo payment method options.
        /// </summary>
        [JsonProperty("payto")]
        [STJS.JsonPropertyName("payto")]
        public SessionPaymentMethodOptionsPaytoOptions Payto { get; set; }

        /// <summary>
        /// contains details about the Pix payment method options.
        /// </summary>
        [JsonProperty("pix")]
        [STJS.JsonPropertyName("pix")]
        public SessionPaymentMethodOptionsPixOptions Pix { get; set; }

        /// <summary>
        /// contains details about the RevolutPay payment method options.
        /// </summary>
        [JsonProperty("revolut_pay")]
        [STJS.JsonPropertyName("revolut_pay")]
        public SessionPaymentMethodOptionsRevolutPayOptions RevolutPay { get; set; }

        /// <summary>
        /// contains details about the Samsung Pay payment method options.
        /// </summary>
        [JsonProperty("samsung_pay")]
        [STJS.JsonPropertyName("samsung_pay")]
        public SessionPaymentMethodOptionsSamsungPayOptions SamsungPay { get; set; }

        /// <summary>
        /// contains details about the Satispay payment method options.
        /// </summary>
        [JsonProperty("satispay")]
        [STJS.JsonPropertyName("satispay")]
        public SessionPaymentMethodOptionsSatispayOptions Satispay { get; set; }

        /// <summary>
        /// contains details about the Sepa Debit payment method options.
        /// </summary>
        [JsonProperty("sepa_debit")]
        [STJS.JsonPropertyName("sepa_debit")]
        public SessionPaymentMethodOptionsSepaDebitOptions SepaDebit { get; set; }

        /// <summary>
        /// contains details about the Sofort payment method options.
        /// </summary>
        [JsonProperty("sofort")]
        [STJS.JsonPropertyName("sofort")]
        public SessionPaymentMethodOptionsSofortOptions Sofort { get; set; }

        /// <summary>
        /// contains details about the Swish payment method options.
        /// </summary>
        [JsonProperty("swish")]
        [STJS.JsonPropertyName("swish")]
        public SessionPaymentMethodOptionsSwishOptions Swish { get; set; }

        /// <summary>
        /// contains details about the TWINT payment method options.
        /// </summary>
        [JsonProperty("twint")]
        [STJS.JsonPropertyName("twint")]
        public SessionPaymentMethodOptionsTwintOptions Twint { get; set; }

        /// <summary>
        /// contains details about the UPI payment method options.
        /// </summary>
        [JsonProperty("upi")]
        [STJS.JsonPropertyName("upi")]
        public SessionPaymentMethodOptionsUpiOptions Upi { get; set; }

        /// <summary>
        /// contains details about the Us Bank Account payment method options.
        /// </summary>
        [JsonProperty("us_bank_account")]
        [STJS.JsonPropertyName("us_bank_account")]
        public SessionPaymentMethodOptionsUsBankAccountOptions UsBankAccount { get; set; }

        /// <summary>
        /// contains details about the WeChat Pay payment method options.
        /// </summary>
        [JsonProperty("wechat_pay")]
        [STJS.JsonPropertyName("wechat_pay")]
        public SessionPaymentMethodOptionsWechatPayOptions WechatPay { get; set; }

        /// <summary>
        /// contains details about the Bizum payment method options.
        /// </summary>
        [JsonProperty("bizum")]
        [STJS.JsonPropertyName("bizum")]
        public SessionPaymentMethodOptionsBizumOptions Bizum { get; set; }
    }
}
