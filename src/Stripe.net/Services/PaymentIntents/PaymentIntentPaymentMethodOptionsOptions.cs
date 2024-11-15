// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentMethodOptionsOptions : INestedOptions
    {
        /// <summary>
        /// If this is a <c>acss_debit</c> PaymentMethod, this sub-hash contains details about the
        /// ACSS Debit payment method options.
        /// </summary>
        [JsonProperty("acss_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("acss_debit")]
#endif

        public PaymentIntentPaymentMethodOptionsAcssDebitOptions AcssDebit { get; set; }

        /// <summary>
        /// If this is an <c>affirm</c> PaymentMethod, this sub-hash contains details about the
        /// Affirm payment method options.
        /// </summary>
        [JsonProperty("affirm")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("affirm")]
#endif

        public PaymentIntentPaymentMethodOptionsAffirmOptions Affirm { get; set; }

        /// <summary>
        /// If this is a <c>afterpay_clearpay</c> PaymentMethod, this sub-hash contains details
        /// about the Afterpay Clearpay payment method options.
        /// </summary>
        [JsonProperty("afterpay_clearpay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("afterpay_clearpay")]
#endif

        public PaymentIntentPaymentMethodOptionsAfterpayClearpayOptions AfterpayClearpay { get; set; }

        /// <summary>
        /// If this is a <c>alipay</c> PaymentMethod, this sub-hash contains details about the
        /// Alipay payment method options.
        /// </summary>
        [JsonProperty("alipay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("alipay")]
#endif

        public PaymentIntentPaymentMethodOptionsAlipayOptions Alipay { get; set; }

        /// <summary>
        /// If this is a <c>alma</c> PaymentMethod, this sub-hash contains details about the Alma
        /// payment method options.
        /// </summary>
        [JsonProperty("alma")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("alma")]
#endif

        public PaymentIntentPaymentMethodOptionsAlmaOptions Alma { get; set; }

        /// <summary>
        /// If this is a <c>amazon_pay</c> PaymentMethod, this sub-hash contains details about the
        /// Amazon Pay payment method options.
        /// </summary>
        [JsonProperty("amazon_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amazon_pay")]
#endif

        public PaymentIntentPaymentMethodOptionsAmazonPayOptions AmazonPay { get; set; }

        /// <summary>
        /// If this is a <c>au_becs_debit</c> PaymentMethod, this sub-hash contains details about
        /// the AU BECS Direct Debit payment method options.
        /// </summary>
        [JsonProperty("au_becs_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("au_becs_debit")]
#endif

        public PaymentIntentPaymentMethodOptionsAuBecsDebitOptions AuBecsDebit { get; set; }

        /// <summary>
        /// If this is a <c>bacs_debit</c> PaymentMethod, this sub-hash contains details about the
        /// BACS Debit payment method options.
        /// </summary>
        [JsonProperty("bacs_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bacs_debit")]
#endif

        public PaymentIntentPaymentMethodOptionsBacsDebitOptions BacsDebit { get; set; }

        /// <summary>
        /// If this is a <c>bancontact</c> PaymentMethod, this sub-hash contains details about the
        /// Bancontact payment method options.
        /// </summary>
        [JsonProperty("bancontact")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bancontact")]
#endif

        public PaymentIntentPaymentMethodOptionsBancontactOptions Bancontact { get; set; }

        /// <summary>
        /// If this is a <c>blik</c> PaymentMethod, this sub-hash contains details about the BLIK
        /// payment method options.
        /// </summary>
        [JsonProperty("blik")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("blik")]
#endif

        public PaymentIntentPaymentMethodOptionsBlikOptions Blik { get; set; }

        /// <summary>
        /// If this is a <c>boleto</c> PaymentMethod, this sub-hash contains details about the
        /// Boleto payment method options.
        /// </summary>
        [JsonProperty("boleto")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("boleto")]
#endif

        public PaymentIntentPaymentMethodOptionsBoletoOptions Boleto { get; set; }

        /// <summary>
        /// Configuration for any card payments attempted on this PaymentIntent.
        /// </summary>
        [JsonProperty("card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card")]
#endif

        public PaymentIntentPaymentMethodOptionsCardOptions Card { get; set; }

        /// <summary>
        /// If this is a <c>card_present</c> PaymentMethod, this sub-hash contains details about the
        /// Card Present payment method options.
        /// </summary>
        [JsonProperty("card_present")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card_present")]
#endif

        public PaymentIntentPaymentMethodOptionsCardPresentOptions CardPresent { get; set; }

        /// <summary>
        /// If this is a <c>cashapp</c> PaymentMethod, this sub-hash contains details about the Cash
        /// App Pay payment method options.
        /// </summary>
        [JsonProperty("cashapp")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cashapp")]
#endif

        public PaymentIntentPaymentMethodOptionsCashappOptions Cashapp { get; set; }

        /// <summary>
        /// If this is a <c>customer balance</c> PaymentMethod, this sub-hash contains details about
        /// the customer balance payment method options.
        /// </summary>
        [JsonProperty("customer_balance")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_balance")]
#endif

        public PaymentIntentPaymentMethodOptionsCustomerBalanceOptions CustomerBalance { get; set; }

        /// <summary>
        /// If this is a <c>eps</c> PaymentMethod, this sub-hash contains details about the EPS
        /// payment method options.
        /// </summary>
        [JsonProperty("eps")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("eps")]
#endif

        public PaymentIntentPaymentMethodOptionsEpsOptions Eps { get; set; }

        /// <summary>
        /// If this is a <c>fpx</c> PaymentMethod, this sub-hash contains details about the FPX
        /// payment method options.
        /// </summary>
        [JsonProperty("fpx")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fpx")]
#endif

        public PaymentIntentPaymentMethodOptionsFpxOptions Fpx { get; set; }

        /// <summary>
        /// If this is a <c>giropay</c> PaymentMethod, this sub-hash contains details about the
        /// Giropay payment method options.
        /// </summary>
        [JsonProperty("giropay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("giropay")]
#endif

        public PaymentIntentPaymentMethodOptionsGiropayOptions Giropay { get; set; }

        /// <summary>
        /// If this is a <c>grabpay</c> PaymentMethod, this sub-hash contains details about the
        /// Grabpay payment method options.
        /// </summary>
        [JsonProperty("grabpay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("grabpay")]
#endif

        public PaymentIntentPaymentMethodOptionsGrabpayOptions Grabpay { get; set; }

        /// <summary>
        /// If this is a <c>ideal</c> PaymentMethod, this sub-hash contains details about the Ideal
        /// payment method options.
        /// </summary>
        [JsonProperty("ideal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ideal")]
#endif

        public PaymentIntentPaymentMethodOptionsIdealOptions Ideal { get; set; }

        /// <summary>
        /// If this is a <c>interac_present</c> PaymentMethod, this sub-hash contains details about
        /// the Card Present payment method options.
        /// </summary>
        [JsonProperty("interac_present")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("interac_present")]
#endif

        public PaymentIntentPaymentMethodOptionsInteracPresentOptions InteracPresent { get; set; }

        /// <summary>
        /// If this is a <c>kakao_pay</c> PaymentMethod, this sub-hash contains details about the
        /// Kakao Pay payment method options.
        /// </summary>
        [JsonProperty("kakao_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("kakao_pay")]
#endif

        public PaymentIntentPaymentMethodOptionsKakaoPayOptions KakaoPay { get; set; }

        /// <summary>
        /// If this is a <c>klarna</c> PaymentMethod, this sub-hash contains details about the
        /// Klarna payment method options.
        /// </summary>
        [JsonProperty("klarna")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("klarna")]
#endif

        public PaymentIntentPaymentMethodOptionsKlarnaOptions Klarna { get; set; }

        /// <summary>
        /// If this is a <c>konbini</c> PaymentMethod, this sub-hash contains details about the
        /// Konbini payment method options.
        /// </summary>
        [JsonProperty("konbini")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("konbini")]
#endif

        public PaymentIntentPaymentMethodOptionsKonbiniOptions Konbini { get; set; }

        /// <summary>
        /// If this is a <c>kr_card</c> PaymentMethod, this sub-hash contains details about the KR
        /// Card payment method options.
        /// </summary>
        [JsonProperty("kr_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("kr_card")]
#endif

        public PaymentIntentPaymentMethodOptionsKrCardOptions KrCard { get; set; }

        /// <summary>
        /// If this is a <c>link</c> PaymentMethod, this sub-hash contains details about the Link
        /// payment method options.
        /// </summary>
        [JsonProperty("link")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("link")]
#endif

        public PaymentIntentPaymentMethodOptionsLinkOptions Link { get; set; }

        /// <summary>
        /// If this is a <c>MobilePay</c> PaymentMethod, this sub-hash contains details about the
        /// MobilePay payment method options.
        /// </summary>
        [JsonProperty("mobilepay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mobilepay")]
#endif

        public PaymentIntentPaymentMethodOptionsMobilepayOptions Mobilepay { get; set; }

        /// <summary>
        /// If this is a <c>multibanco</c> PaymentMethod, this sub-hash contains details about the
        /// Multibanco payment method options.
        /// </summary>
        [JsonProperty("multibanco")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("multibanco")]
#endif

        public PaymentIntentPaymentMethodOptionsMultibancoOptions Multibanco { get; set; }

        /// <summary>
        /// If this is a <c>naver_pay</c> PaymentMethod, this sub-hash contains details about the
        /// Naver Pay payment method options.
        /// </summary>
        [JsonProperty("naver_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("naver_pay")]
#endif

        public PaymentIntentPaymentMethodOptionsNaverPayOptions NaverPay { get; set; }

        /// <summary>
        /// If this is a <c>oxxo</c> PaymentMethod, this sub-hash contains details about the OXXO
        /// payment method options.
        /// </summary>
        [JsonProperty("oxxo")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("oxxo")]
#endif

        public PaymentIntentPaymentMethodOptionsOxxoOptions Oxxo { get; set; }

        /// <summary>
        /// If this is a <c>p24</c> PaymentMethod, this sub-hash contains details about the
        /// Przelewy24 payment method options.
        /// </summary>
        [JsonProperty("p24")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("p24")]
#endif

        public PaymentIntentPaymentMethodOptionsP24Options P24 { get; set; }

        /// <summary>
        /// If this is a <c>payco</c> PaymentMethod, this sub-hash contains details about the PAYCO
        /// payment method options.
        /// </summary>
        [JsonProperty("payco")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payco")]
#endif

        public PaymentIntentPaymentMethodOptionsPaycoOptions Payco { get; set; }

        /// <summary>
        /// If this is a <c>paynow</c> PaymentMethod, this sub-hash contains details about the
        /// PayNow payment method options.
        /// </summary>
        [JsonProperty("paynow")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paynow")]
#endif

        public PaymentIntentPaymentMethodOptionsPaynowOptions Paynow { get; set; }

        /// <summary>
        /// If this is a <c>paypal</c> PaymentMethod, this sub-hash contains details about the
        /// PayPal payment method options.
        /// </summary>
        [JsonProperty("paypal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paypal")]
#endif

        public PaymentIntentPaymentMethodOptionsPaypalOptions Paypal { get; set; }

        /// <summary>
        /// If this is a <c>pix</c> PaymentMethod, this sub-hash contains details about the Pix
        /// payment method options.
        /// </summary>
        [JsonProperty("pix")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pix")]
#endif

        public PaymentIntentPaymentMethodOptionsPixOptions Pix { get; set; }

        /// <summary>
        /// If this is a <c>promptpay</c> PaymentMethod, this sub-hash contains details about the
        /// PromptPay payment method options.
        /// </summary>
        [JsonProperty("promptpay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("promptpay")]
#endif

        public PaymentIntentPaymentMethodOptionsPromptpayOptions Promptpay { get; set; }

        /// <summary>
        /// If this is a <c>revolut_pay</c> PaymentMethod, this sub-hash contains details about the
        /// Revolut Pay payment method options.
        /// </summary>
        [JsonProperty("revolut_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("revolut_pay")]
#endif

        public PaymentIntentPaymentMethodOptionsRevolutPayOptions RevolutPay { get; set; }

        /// <summary>
        /// If this is a <c>samsung_pay</c> PaymentMethod, this sub-hash contains details about the
        /// Samsung Pay payment method options.
        /// </summary>
        [JsonProperty("samsung_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("samsung_pay")]
#endif

        public PaymentIntentPaymentMethodOptionsSamsungPayOptions SamsungPay { get; set; }

        /// <summary>
        /// If this is a <c>sepa_debit</c> PaymentIntent, this sub-hash contains details about the
        /// SEPA Debit payment method options.
        /// </summary>
        [JsonProperty("sepa_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sepa_debit")]
#endif

        public PaymentIntentPaymentMethodOptionsSepaDebitOptions SepaDebit { get; set; }

        /// <summary>
        /// If this is a <c>sofort</c> PaymentMethod, this sub-hash contains details about the
        /// SOFORT payment method options.
        /// </summary>
        [JsonProperty("sofort")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sofort")]
#endif

        public PaymentIntentPaymentMethodOptionsSofortOptions Sofort { get; set; }

        /// <summary>
        /// If this is a <c>Swish</c> PaymentMethod, this sub-hash contains details about the Swish
        /// payment method options.
        /// </summary>
        [JsonProperty("swish")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("swish")]
#endif

        public PaymentIntentPaymentMethodOptionsSwishOptions Swish { get; set; }

        /// <summary>
        /// If this is a <c>twint</c> PaymentMethod, this sub-hash contains details about the TWINT
        /// payment method options.
        /// </summary>
        [JsonProperty("twint")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("twint")]
#endif

        public PaymentIntentPaymentMethodOptionsTwintOptions Twint { get; set; }

        /// <summary>
        /// If this is a <c>us_bank_account</c> PaymentMethod, this sub-hash contains details about
        /// the US bank account payment method options.
        /// </summary>
        [JsonProperty("us_bank_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("us_bank_account")]
#endif

        public PaymentIntentPaymentMethodOptionsUsBankAccountOptions UsBankAccount { get; set; }

        /// <summary>
        /// If this is a <c>wechat_pay</c> PaymentMethod, this sub-hash contains details about the
        /// WeChat Pay payment method options.
        /// </summary>
        [JsonProperty("wechat_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("wechat_pay")]
#endif

        public PaymentIntentPaymentMethodOptionsWechatPayOptions WechatPay { get; set; }

        /// <summary>
        /// If this is a <c>zip</c> PaymentMethod, this sub-hash contains details about the Zip
        /// payment method options.
        /// </summary>
        [JsonProperty("zip")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("zip")]
#endif

        public PaymentIntentPaymentMethodOptionsZipOptions Zip { get; set; }
    }
}
