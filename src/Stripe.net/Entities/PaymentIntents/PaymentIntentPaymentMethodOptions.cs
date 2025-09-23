// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentMethodOptions : StripeEntity<PaymentIntentPaymentMethodOptions>
    {
        [JsonProperty("acss_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("acss_debit")]
#endif
        public PaymentIntentPaymentMethodOptionsAcssDebit AcssDebit { get; set; }

        [JsonProperty("affirm")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("affirm")]
#endif
        public PaymentIntentPaymentMethodOptionsAffirm Affirm { get; set; }

        [JsonProperty("afterpay_clearpay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("afterpay_clearpay")]
#endif
        public PaymentIntentPaymentMethodOptionsAfterpayClearpay AfterpayClearpay { get; set; }

        [JsonProperty("alipay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("alipay")]
#endif
        public PaymentIntentPaymentMethodOptionsAlipay Alipay { get; set; }

        [JsonProperty("alma")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("alma")]
#endif
        public PaymentIntentPaymentMethodOptionsAlma Alma { get; set; }

        [JsonProperty("amazon_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amazon_pay")]
#endif
        public PaymentIntentPaymentMethodOptionsAmazonPay AmazonPay { get; set; }

        [JsonProperty("au_becs_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("au_becs_debit")]
#endif
        public PaymentIntentPaymentMethodOptionsAuBecsDebit AuBecsDebit { get; set; }

        [JsonProperty("bacs_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bacs_debit")]
#endif
        public PaymentIntentPaymentMethodOptionsBacsDebit BacsDebit { get; set; }

        [JsonProperty("bancontact")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bancontact")]
#endif
        public PaymentIntentPaymentMethodOptionsBancontact Bancontact { get; set; }

        [JsonProperty("billie")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billie")]
#endif
        public PaymentIntentPaymentMethodOptionsBillie Billie { get; set; }

        [JsonProperty("blik")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("blik")]
#endif
        public PaymentIntentPaymentMethodOptionsBlik Blik { get; set; }

        [JsonProperty("boleto")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("boleto")]
#endif
        public PaymentIntentPaymentMethodOptionsBoleto Boleto { get; set; }

        [JsonProperty("card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card")]
#endif
        public PaymentIntentPaymentMethodOptionsCard Card { get; set; }

        [JsonProperty("card_present")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card_present")]
#endif
        public PaymentIntentPaymentMethodOptionsCardPresent CardPresent { get; set; }

        [JsonProperty("cashapp")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cashapp")]
#endif
        public PaymentIntentPaymentMethodOptionsCashapp Cashapp { get; set; }

        [JsonProperty("crypto")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("crypto")]
#endif
        public PaymentIntentPaymentMethodOptionsCrypto Crypto { get; set; }

        [JsonProperty("customer_balance")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_balance")]
#endif
        public PaymentIntentPaymentMethodOptionsCustomerBalance CustomerBalance { get; set; }

        [JsonProperty("eps")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("eps")]
#endif
        public PaymentIntentPaymentMethodOptionsEps Eps { get; set; }

        [JsonProperty("fpx")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fpx")]
#endif
        public PaymentIntentPaymentMethodOptionsFpx Fpx { get; set; }

        [JsonProperty("giropay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("giropay")]
#endif
        public PaymentIntentPaymentMethodOptionsGiropay Giropay { get; set; }

        [JsonProperty("grabpay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("grabpay")]
#endif
        public PaymentIntentPaymentMethodOptionsGrabpay Grabpay { get; set; }

        [JsonProperty("ideal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ideal")]
#endif
        public PaymentIntentPaymentMethodOptionsIdeal Ideal { get; set; }

        [JsonProperty("interac_present")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("interac_present")]
#endif
        public PaymentIntentPaymentMethodOptionsInteracPresent InteracPresent { get; set; }

        [JsonProperty("kakao_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("kakao_pay")]
#endif
        public PaymentIntentPaymentMethodOptionsKakaoPay KakaoPay { get; set; }

        [JsonProperty("klarna")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("klarna")]
#endif
        public PaymentIntentPaymentMethodOptionsKlarna Klarna { get; set; }

        [JsonProperty("konbini")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("konbini")]
#endif
        public PaymentIntentPaymentMethodOptionsKonbini Konbini { get; set; }

        [JsonProperty("kr_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("kr_card")]
#endif
        public PaymentIntentPaymentMethodOptionsKrCard KrCard { get; set; }

        [JsonProperty("link")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("link")]
#endif
        public PaymentIntentPaymentMethodOptionsLink Link { get; set; }

        [JsonProperty("mb_way")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mb_way")]
#endif
        public PaymentIntentPaymentMethodOptionsMbWay MbWay { get; set; }

        [JsonProperty("mobilepay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mobilepay")]
#endif
        public PaymentIntentPaymentMethodOptionsMobilepay Mobilepay { get; set; }

        [JsonProperty("multibanco")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("multibanco")]
#endif
        public PaymentIntentPaymentMethodOptionsMultibanco Multibanco { get; set; }

        [JsonProperty("naver_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("naver_pay")]
#endif
        public PaymentIntentPaymentMethodOptionsNaverPay NaverPay { get; set; }

        [JsonProperty("nz_bank_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("nz_bank_account")]
#endif
        public PaymentIntentPaymentMethodOptionsNzBankAccount NzBankAccount { get; set; }

        [JsonProperty("oxxo")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("oxxo")]
#endif
        public PaymentIntentPaymentMethodOptionsOxxo Oxxo { get; set; }

        [JsonProperty("p24")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("p24")]
#endif
        public PaymentIntentPaymentMethodOptionsP24 P24 { get; set; }

        [JsonProperty("pay_by_bank")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pay_by_bank")]
#endif
        public PaymentIntentPaymentMethodOptionsPayByBank PayByBank { get; set; }

        [JsonProperty("payco")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payco")]
#endif
        public PaymentIntentPaymentMethodOptionsPayco Payco { get; set; }

        [JsonProperty("paynow")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paynow")]
#endif
        public PaymentIntentPaymentMethodOptionsPaynow Paynow { get; set; }

        [JsonProperty("paypal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paypal")]
#endif
        public PaymentIntentPaymentMethodOptionsPaypal Paypal { get; set; }

        [JsonProperty("paypay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paypay")]
#endif
        public PaymentIntentPaymentMethodOptionsPaypay Paypay { get; set; }

        [JsonProperty("pix")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pix")]
#endif
        public PaymentIntentPaymentMethodOptionsPix Pix { get; set; }

        [JsonProperty("promptpay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("promptpay")]
#endif
        public PaymentIntentPaymentMethodOptionsPromptpay Promptpay { get; set; }

        [JsonProperty("revolut_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("revolut_pay")]
#endif
        public PaymentIntentPaymentMethodOptionsRevolutPay RevolutPay { get; set; }

        [JsonProperty("samsung_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("samsung_pay")]
#endif
        public PaymentIntentPaymentMethodOptionsSamsungPay SamsungPay { get; set; }

        [JsonProperty("satispay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("satispay")]
#endif
        public PaymentIntentPaymentMethodOptionsSatispay Satispay { get; set; }

        [JsonProperty("sepa_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sepa_debit")]
#endif
        public PaymentIntentPaymentMethodOptionsSepaDebit SepaDebit { get; set; }

        [JsonProperty("sofort")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sofort")]
#endif
        public PaymentIntentPaymentMethodOptionsSofort Sofort { get; set; }

        [JsonProperty("swish")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("swish")]
#endif
        public PaymentIntentPaymentMethodOptionsSwish Swish { get; set; }

        [JsonProperty("twint")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("twint")]
#endif
        public PaymentIntentPaymentMethodOptionsTwint Twint { get; set; }

        [JsonProperty("us_bank_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("us_bank_account")]
#endif
        public PaymentIntentPaymentMethodOptionsUsBankAccount UsBankAccount { get; set; }

        [JsonProperty("wechat_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("wechat_pay")]
#endif
        public PaymentIntentPaymentMethodOptionsWechatPay WechatPay { get; set; }

        [JsonProperty("zip")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("zip")]
#endif
        public PaymentIntentPaymentMethodOptionsZip Zip { get; set; }
    }
}
