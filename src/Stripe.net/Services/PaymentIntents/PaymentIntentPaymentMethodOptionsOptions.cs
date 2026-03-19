// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentMethodOptionsOptions : INestedOptions
    {
        /// <summary>
        /// If this is a <c>acss_debit</c> PaymentMethod, this sub-hash contains details about the
        /// ACSS Debit payment method options.
        /// </summary>
        [JsonProperty("acss_debit")]
        [STJS.JsonPropertyName("acss_debit")]
        public PaymentIntentPaymentMethodOptionsAcssDebitOptions AcssDebit { get; set; }

        /// <summary>
        /// If this is an <c>affirm</c> PaymentMethod, this sub-hash contains details about the
        /// Affirm payment method options.
        /// </summary>
        [JsonProperty("affirm")]
        [STJS.JsonPropertyName("affirm")]
        public PaymentIntentPaymentMethodOptionsAffirmOptions Affirm { get; set; }

        /// <summary>
        /// If this is a <c>afterpay_clearpay</c> PaymentMethod, this sub-hash contains details
        /// about the Afterpay Clearpay payment method options.
        /// </summary>
        [JsonProperty("afterpay_clearpay")]
        [STJS.JsonPropertyName("afterpay_clearpay")]
        public PaymentIntentPaymentMethodOptionsAfterpayClearpayOptions AfterpayClearpay { get; set; }

        /// <summary>
        /// If this is a <c>alipay</c> PaymentMethod, this sub-hash contains details about the
        /// Alipay payment method options.
        /// </summary>
        [JsonProperty("alipay")]
        [STJS.JsonPropertyName("alipay")]
        public PaymentIntentPaymentMethodOptionsAlipayOptions Alipay { get; set; }

        /// <summary>
        /// If this is a <c>alma</c> PaymentMethod, this sub-hash contains details about the Alma
        /// payment method options.
        /// </summary>
        [JsonProperty("alma")]
        [STJS.JsonPropertyName("alma")]
        public PaymentIntentPaymentMethodOptionsAlmaOptions Alma { get; set; }

        /// <summary>
        /// If this is a <c>amazon_pay</c> PaymentMethod, this sub-hash contains details about the
        /// Amazon Pay payment method options.
        /// </summary>
        [JsonProperty("amazon_pay")]
        [STJS.JsonPropertyName("amazon_pay")]
        public PaymentIntentPaymentMethodOptionsAmazonPayOptions AmazonPay { get; set; }

        /// <summary>
        /// If this is a <c>au_becs_debit</c> PaymentMethod, this sub-hash contains details about
        /// the AU BECS Direct Debit payment method options.
        /// </summary>
        [JsonProperty("au_becs_debit")]
        [STJS.JsonPropertyName("au_becs_debit")]
        public PaymentIntentPaymentMethodOptionsAuBecsDebitOptions AuBecsDebit { get; set; }

        /// <summary>
        /// If this is a <c>bacs_debit</c> PaymentMethod, this sub-hash contains details about the
        /// BACS Debit payment method options.
        /// </summary>
        [JsonProperty("bacs_debit")]
        [STJS.JsonPropertyName("bacs_debit")]
        public PaymentIntentPaymentMethodOptionsBacsDebitOptions BacsDebit { get; set; }

        /// <summary>
        /// If this is a <c>bancontact</c> PaymentMethod, this sub-hash contains details about the
        /// Bancontact payment method options.
        /// </summary>
        [JsonProperty("bancontact")]
        [STJS.JsonPropertyName("bancontact")]
        public PaymentIntentPaymentMethodOptionsBancontactOptions Bancontact { get; set; }

        /// <summary>
        /// If this is a <c>billie</c> PaymentMethod, this sub-hash contains details about the
        /// Billie payment method options.
        /// </summary>
        [JsonProperty("billie")]
        [STJS.JsonPropertyName("billie")]
        public PaymentIntentPaymentMethodOptionsBillieOptions Billie { get; set; }

        /// <summary>
        /// If this is a <c>blik</c> PaymentMethod, this sub-hash contains details about the BLIK
        /// payment method options.
        /// </summary>
        [JsonProperty("blik")]
        [STJS.JsonPropertyName("blik")]
        public PaymentIntentPaymentMethodOptionsBlikOptions Blik { get; set; }

        /// <summary>
        /// If this is a <c>boleto</c> PaymentMethod, this sub-hash contains details about the
        /// Boleto payment method options.
        /// </summary>
        [JsonProperty("boleto")]
        [STJS.JsonPropertyName("boleto")]
        public PaymentIntentPaymentMethodOptionsBoletoOptions Boleto { get; set; }

        /// <summary>
        /// Configuration for any card payments attempted on this PaymentIntent.
        /// </summary>
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public PaymentIntentPaymentMethodOptionsCardOptions Card { get; set; }

        /// <summary>
        /// If this is a <c>card_present</c> PaymentMethod, this sub-hash contains details about the
        /// Card Present payment method options.
        /// </summary>
        [JsonProperty("card_present")]
        [STJS.JsonPropertyName("card_present")]
        public PaymentIntentPaymentMethodOptionsCardPresentOptions CardPresent { get; set; }

        /// <summary>
        /// If this is a <c>cashapp</c> PaymentMethod, this sub-hash contains details about the Cash
        /// App Pay payment method options.
        /// </summary>
        [JsonProperty("cashapp")]
        [STJS.JsonPropertyName("cashapp")]
        public PaymentIntentPaymentMethodOptionsCashappOptions Cashapp { get; set; }

        /// <summary>
        /// If this is a <c>crypto</c> PaymentMethod, this sub-hash contains details about the
        /// Crypto payment method options.
        /// </summary>
        [JsonProperty("crypto")]
        [STJS.JsonPropertyName("crypto")]
        public PaymentIntentPaymentMethodOptionsCryptoOptions Crypto { get; set; }

        /// <summary>
        /// If this is a <c>customer balance</c> PaymentMethod, this sub-hash contains details about
        /// the customer balance payment method options.
        /// </summary>
        [JsonProperty("customer_balance")]
        [STJS.JsonPropertyName("customer_balance")]
        public PaymentIntentPaymentMethodOptionsCustomerBalanceOptions CustomerBalance { get; set; }

        /// <summary>
        /// If this is a <c>eps</c> PaymentMethod, this sub-hash contains details about the EPS
        /// payment method options.
        /// </summary>
        [JsonProperty("eps")]
        [STJS.JsonPropertyName("eps")]
        public PaymentIntentPaymentMethodOptionsEpsOptions Eps { get; set; }

        /// <summary>
        /// If this is a <c>fpx</c> PaymentMethod, this sub-hash contains details about the FPX
        /// payment method options.
        /// </summary>
        [JsonProperty("fpx")]
        [STJS.JsonPropertyName("fpx")]
        public PaymentIntentPaymentMethodOptionsFpxOptions Fpx { get; set; }

        /// <summary>
        /// If this is a <c>giropay</c> PaymentMethod, this sub-hash contains details about the
        /// Giropay payment method options.
        /// </summary>
        [JsonProperty("giropay")]
        [STJS.JsonPropertyName("giropay")]
        public PaymentIntentPaymentMethodOptionsGiropayOptions Giropay { get; set; }

        /// <summary>
        /// If this is a <c>grabpay</c> PaymentMethod, this sub-hash contains details about the
        /// Grabpay payment method options.
        /// </summary>
        [JsonProperty("grabpay")]
        [STJS.JsonPropertyName("grabpay")]
        public PaymentIntentPaymentMethodOptionsGrabpayOptions Grabpay { get; set; }

        /// <summary>
        /// If this is a <c>ideal</c> PaymentMethod, this sub-hash contains details about the Ideal
        /// payment method options.
        /// </summary>
        [JsonProperty("ideal")]
        [STJS.JsonPropertyName("ideal")]
        public PaymentIntentPaymentMethodOptionsIdealOptions Ideal { get; set; }

        /// <summary>
        /// If this is a <c>interac_present</c> PaymentMethod, this sub-hash contains details about
        /// the Card Present payment method options.
        /// </summary>
        [JsonProperty("interac_present")]
        [STJS.JsonPropertyName("interac_present")]
        public PaymentIntentPaymentMethodOptionsInteracPresentOptions InteracPresent { get; set; }

        /// <summary>
        /// If this is a <c>kakao_pay</c> PaymentMethod, this sub-hash contains details about the
        /// Kakao Pay payment method options.
        /// </summary>
        [JsonProperty("kakao_pay")]
        [STJS.JsonPropertyName("kakao_pay")]
        public PaymentIntentPaymentMethodOptionsKakaoPayOptions KakaoPay { get; set; }

        /// <summary>
        /// If this is a <c>klarna</c> PaymentMethod, this sub-hash contains details about the
        /// Klarna payment method options.
        /// </summary>
        [JsonProperty("klarna")]
        [STJS.JsonPropertyName("klarna")]
        public PaymentIntentPaymentMethodOptionsKlarnaOptions Klarna { get; set; }

        /// <summary>
        /// If this is a <c>konbini</c> PaymentMethod, this sub-hash contains details about the
        /// Konbini payment method options.
        /// </summary>
        [JsonProperty("konbini")]
        [STJS.JsonPropertyName("konbini")]
        public PaymentIntentPaymentMethodOptionsKonbiniOptions Konbini { get; set; }

        /// <summary>
        /// If this is a <c>kr_card</c> PaymentMethod, this sub-hash contains details about the KR
        /// Card payment method options.
        /// </summary>
        [JsonProperty("kr_card")]
        [STJS.JsonPropertyName("kr_card")]
        public PaymentIntentPaymentMethodOptionsKrCardOptions KrCard { get; set; }

        /// <summary>
        /// If this is a <c>link</c> PaymentMethod, this sub-hash contains details about the Link
        /// payment method options.
        /// </summary>
        [JsonProperty("link")]
        [STJS.JsonPropertyName("link")]
        public PaymentIntentPaymentMethodOptionsLinkOptions Link { get; set; }

        /// <summary>
        /// If this is a <c>mb_way</c> PaymentMethod, this sub-hash contains details about the MB
        /// WAY payment method options.
        /// </summary>
        [JsonProperty("mb_way")]
        [STJS.JsonPropertyName("mb_way")]
        public PaymentIntentPaymentMethodOptionsMbWayOptions MbWay { get; set; }

        /// <summary>
        /// If this is a <c>MobilePay</c> PaymentMethod, this sub-hash contains details about the
        /// MobilePay payment method options.
        /// </summary>
        [JsonProperty("mobilepay")]
        [STJS.JsonPropertyName("mobilepay")]
        public PaymentIntentPaymentMethodOptionsMobilepayOptions Mobilepay { get; set; }

        /// <summary>
        /// If this is a <c>multibanco</c> PaymentMethod, this sub-hash contains details about the
        /// Multibanco payment method options.
        /// </summary>
        [JsonProperty("multibanco")]
        [STJS.JsonPropertyName("multibanco")]
        public PaymentIntentPaymentMethodOptionsMultibancoOptions Multibanco { get; set; }

        /// <summary>
        /// If this is a <c>naver_pay</c> PaymentMethod, this sub-hash contains details about the
        /// Naver Pay payment method options.
        /// </summary>
        [JsonProperty("naver_pay")]
        [STJS.JsonPropertyName("naver_pay")]
        public PaymentIntentPaymentMethodOptionsNaverPayOptions NaverPay { get; set; }

        /// <summary>
        /// If this is a <c>nz_bank_account</c> PaymentMethod, this sub-hash contains details about
        /// the NZ BECS Direct Debit payment method options.
        /// </summary>
        [JsonProperty("nz_bank_account")]
        [STJS.JsonPropertyName("nz_bank_account")]
        public PaymentIntentPaymentMethodOptionsNzBankAccountOptions NzBankAccount { get; set; }

        /// <summary>
        /// If this is a <c>oxxo</c> PaymentMethod, this sub-hash contains details about the OXXO
        /// payment method options.
        /// </summary>
        [JsonProperty("oxxo")]
        [STJS.JsonPropertyName("oxxo")]
        public PaymentIntentPaymentMethodOptionsOxxoOptions Oxxo { get; set; }

        /// <summary>
        /// If this is a <c>p24</c> PaymentMethod, this sub-hash contains details about the
        /// Przelewy24 payment method options.
        /// </summary>
        [JsonProperty("p24")]
        [STJS.JsonPropertyName("p24")]
        public PaymentIntentPaymentMethodOptionsP24Options P24 { get; set; }

        /// <summary>
        /// If this is a <c>pay_by_bank</c> PaymentMethod, this sub-hash contains details about the
        /// PayByBank payment method options.
        /// </summary>
        [JsonProperty("pay_by_bank")]
        [STJS.JsonPropertyName("pay_by_bank")]
        public PaymentIntentPaymentMethodOptionsPayByBankOptions PayByBank { get; set; }

        /// <summary>
        /// If this is a <c>payco</c> PaymentMethod, this sub-hash contains details about the PAYCO
        /// payment method options.
        /// </summary>
        [JsonProperty("payco")]
        [STJS.JsonPropertyName("payco")]
        public PaymentIntentPaymentMethodOptionsPaycoOptions Payco { get; set; }

        /// <summary>
        /// If this is a <c>paynow</c> PaymentMethod, this sub-hash contains details about the
        /// PayNow payment method options.
        /// </summary>
        [JsonProperty("paynow")]
        [STJS.JsonPropertyName("paynow")]
        public PaymentIntentPaymentMethodOptionsPaynowOptions Paynow { get; set; }

        /// <summary>
        /// If this is a <c>paypal</c> PaymentMethod, this sub-hash contains details about the
        /// PayPal payment method options.
        /// </summary>
        [JsonProperty("paypal")]
        [STJS.JsonPropertyName("paypal")]
        public PaymentIntentPaymentMethodOptionsPaypalOptions Paypal { get; set; }

        /// <summary>
        /// If this is a <c>payto</c> PaymentMethod, this sub-hash contains details about the PayTo
        /// payment method options.
        /// </summary>
        [JsonProperty("payto")]
        [STJS.JsonPropertyName("payto")]
        public PaymentIntentPaymentMethodOptionsPaytoOptions Payto { get; set; }

        /// <summary>
        /// If this is a <c>pix</c> PaymentMethod, this sub-hash contains details about the Pix
        /// payment method options.
        /// </summary>
        [JsonProperty("pix")]
        [STJS.JsonPropertyName("pix")]
        public PaymentIntentPaymentMethodOptionsPixOptions Pix { get; set; }

        /// <summary>
        /// If this is a <c>promptpay</c> PaymentMethod, this sub-hash contains details about the
        /// PromptPay payment method options.
        /// </summary>
        [JsonProperty("promptpay")]
        [STJS.JsonPropertyName("promptpay")]
        public PaymentIntentPaymentMethodOptionsPromptpayOptions Promptpay { get; set; }

        /// <summary>
        /// If this is a <c>revolut_pay</c> PaymentMethod, this sub-hash contains details about the
        /// Revolut Pay payment method options.
        /// </summary>
        [JsonProperty("revolut_pay")]
        [STJS.JsonPropertyName("revolut_pay")]
        public PaymentIntentPaymentMethodOptionsRevolutPayOptions RevolutPay { get; set; }

        /// <summary>
        /// If this is a <c>samsung_pay</c> PaymentMethod, this sub-hash contains details about the
        /// Samsung Pay payment method options.
        /// </summary>
        [JsonProperty("samsung_pay")]
        [STJS.JsonPropertyName("samsung_pay")]
        public PaymentIntentPaymentMethodOptionsSamsungPayOptions SamsungPay { get; set; }

        /// <summary>
        /// If this is a <c>satispay</c> PaymentMethod, this sub-hash contains details about the
        /// Satispay payment method options.
        /// </summary>
        [JsonProperty("satispay")]
        [STJS.JsonPropertyName("satispay")]
        public PaymentIntentPaymentMethodOptionsSatispayOptions Satispay { get; set; }

        /// <summary>
        /// If this is a <c>sepa_debit</c> PaymentIntent, this sub-hash contains details about the
        /// SEPA Debit payment method options.
        /// </summary>
        [JsonProperty("sepa_debit")]
        [STJS.JsonPropertyName("sepa_debit")]
        public PaymentIntentPaymentMethodOptionsSepaDebitOptions SepaDebit { get; set; }

        /// <summary>
        /// If this is a <c>sofort</c> PaymentMethod, this sub-hash contains details about the
        /// SOFORT payment method options.
        /// </summary>
        [JsonProperty("sofort")]
        [STJS.JsonPropertyName("sofort")]
        public PaymentIntentPaymentMethodOptionsSofortOptions Sofort { get; set; }

        /// <summary>
        /// If this is a <c>Swish</c> PaymentMethod, this sub-hash contains details about the Swish
        /// payment method options.
        /// </summary>
        [JsonProperty("swish")]
        [STJS.JsonPropertyName("swish")]
        public PaymentIntentPaymentMethodOptionsSwishOptions Swish { get; set; }

        /// <summary>
        /// If this is a <c>twint</c> PaymentMethod, this sub-hash contains details about the TWINT
        /// payment method options.
        /// </summary>
        [JsonProperty("twint")]
        [STJS.JsonPropertyName("twint")]
        public PaymentIntentPaymentMethodOptionsTwintOptions Twint { get; set; }

        /// <summary>
        /// If this is a <c>upi</c> PaymentIntent, this sub-hash contains details about the UPI
        /// payment method options.
        /// </summary>
        [JsonProperty("upi")]
        [STJS.JsonPropertyName("upi")]
        public PaymentIntentPaymentMethodOptionsUpiOptions Upi { get; set; }

        /// <summary>
        /// If this is a <c>us_bank_account</c> PaymentMethod, this sub-hash contains details about
        /// the US bank account payment method options.
        /// </summary>
        [JsonProperty("us_bank_account")]
        [STJS.JsonPropertyName("us_bank_account")]
        public PaymentIntentPaymentMethodOptionsUsBankAccountOptions UsBankAccount { get; set; }

        /// <summary>
        /// If this is a <c>wechat_pay</c> PaymentMethod, this sub-hash contains details about the
        /// WeChat Pay payment method options.
        /// </summary>
        [JsonProperty("wechat_pay")]
        [STJS.JsonPropertyName("wechat_pay")]
        public PaymentIntentPaymentMethodOptionsWechatPayOptions WechatPay { get; set; }

        /// <summary>
        /// If this is a <c>zip</c> PaymentMethod, this sub-hash contains details about the Zip
        /// payment method options.
        /// </summary>
        [JsonProperty("zip")]
        [STJS.JsonPropertyName("zip")]
        public PaymentIntentPaymentMethodOptionsZipOptions Zip { get; set; }
    }
}
