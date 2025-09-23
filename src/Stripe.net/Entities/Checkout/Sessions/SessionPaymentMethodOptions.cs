// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionPaymentMethodOptions : StripeEntity<SessionPaymentMethodOptions>
    {
        [JsonProperty("acss_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("acss_debit")]
#endif
        public SessionPaymentMethodOptionsAcssDebit AcssDebit { get; set; }

        [JsonProperty("affirm")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("affirm")]
#endif
        public SessionPaymentMethodOptionsAffirm Affirm { get; set; }

        [JsonProperty("afterpay_clearpay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("afterpay_clearpay")]
#endif
        public SessionPaymentMethodOptionsAfterpayClearpay AfterpayClearpay { get; set; }

        [JsonProperty("alipay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("alipay")]
#endif
        public SessionPaymentMethodOptionsAlipay Alipay { get; set; }

        [JsonProperty("alma")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("alma")]
#endif
        public SessionPaymentMethodOptionsAlma Alma { get; set; }

        [JsonProperty("amazon_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amazon_pay")]
#endif
        public SessionPaymentMethodOptionsAmazonPay AmazonPay { get; set; }

        [JsonProperty("au_becs_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("au_becs_debit")]
#endif
        public SessionPaymentMethodOptionsAuBecsDebit AuBecsDebit { get; set; }

        [JsonProperty("bacs_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bacs_debit")]
#endif
        public SessionPaymentMethodOptionsBacsDebit BacsDebit { get; set; }

        [JsonProperty("bancontact")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bancontact")]
#endif
        public SessionPaymentMethodOptionsBancontact Bancontact { get; set; }

        [JsonProperty("billie")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billie")]
#endif
        public SessionPaymentMethodOptionsBillie Billie { get; set; }

        [JsonProperty("boleto")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("boleto")]
#endif
        public SessionPaymentMethodOptionsBoleto Boleto { get; set; }

        [JsonProperty("card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card")]
#endif
        public SessionPaymentMethodOptionsCard Card { get; set; }

        [JsonProperty("cashapp")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cashapp")]
#endif
        public SessionPaymentMethodOptionsCashapp Cashapp { get; set; }

        [JsonProperty("customer_balance")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_balance")]
#endif
        public SessionPaymentMethodOptionsCustomerBalance CustomerBalance { get; set; }

        [JsonProperty("eps")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("eps")]
#endif
        public SessionPaymentMethodOptionsEps Eps { get; set; }

        [JsonProperty("fpx")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fpx")]
#endif
        public SessionPaymentMethodOptionsFpx Fpx { get; set; }

        [JsonProperty("giropay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("giropay")]
#endif
        public SessionPaymentMethodOptionsGiropay Giropay { get; set; }

        [JsonProperty("grabpay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("grabpay")]
#endif
        public SessionPaymentMethodOptionsGrabpay Grabpay { get; set; }

        [JsonProperty("ideal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ideal")]
#endif
        public SessionPaymentMethodOptionsIdeal Ideal { get; set; }

        [JsonProperty("kakao_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("kakao_pay")]
#endif
        public SessionPaymentMethodOptionsKakaoPay KakaoPay { get; set; }

        [JsonProperty("klarna")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("klarna")]
#endif
        public SessionPaymentMethodOptionsKlarna Klarna { get; set; }

        [JsonProperty("konbini")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("konbini")]
#endif
        public SessionPaymentMethodOptionsKonbini Konbini { get; set; }

        [JsonProperty("kr_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("kr_card")]
#endif
        public SessionPaymentMethodOptionsKrCard KrCard { get; set; }

        [JsonProperty("link")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("link")]
#endif
        public SessionPaymentMethodOptionsLink Link { get; set; }

        [JsonProperty("mobilepay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mobilepay")]
#endif
        public SessionPaymentMethodOptionsMobilepay Mobilepay { get; set; }

        [JsonProperty("multibanco")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("multibanco")]
#endif
        public SessionPaymentMethodOptionsMultibanco Multibanco { get; set; }

        [JsonProperty("naver_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("naver_pay")]
#endif
        public SessionPaymentMethodOptionsNaverPay NaverPay { get; set; }

        [JsonProperty("oxxo")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("oxxo")]
#endif
        public SessionPaymentMethodOptionsOxxo Oxxo { get; set; }

        [JsonProperty("p24")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("p24")]
#endif
        public SessionPaymentMethodOptionsP24 P24 { get; set; }

        [JsonProperty("payco")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payco")]
#endif
        public SessionPaymentMethodOptionsPayco Payco { get; set; }

        [JsonProperty("paynow")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paynow")]
#endif
        public SessionPaymentMethodOptionsPaynow Paynow { get; set; }

        [JsonProperty("paypal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paypal")]
#endif
        public SessionPaymentMethodOptionsPaypal Paypal { get; set; }

        [JsonProperty("pix")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pix")]
#endif
        public SessionPaymentMethodOptionsPix Pix { get; set; }

        [JsonProperty("revolut_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("revolut_pay")]
#endif
        public SessionPaymentMethodOptionsRevolutPay RevolutPay { get; set; }

        [JsonProperty("samsung_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("samsung_pay")]
#endif
        public SessionPaymentMethodOptionsSamsungPay SamsungPay { get; set; }

        [JsonProperty("satispay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("satispay")]
#endif
        public SessionPaymentMethodOptionsSatispay Satispay { get; set; }

        [JsonProperty("sepa_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sepa_debit")]
#endif
        public SessionPaymentMethodOptionsSepaDebit SepaDebit { get; set; }

        [JsonProperty("sofort")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sofort")]
#endif
        public SessionPaymentMethodOptionsSofort Sofort { get; set; }

        [JsonProperty("swish")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("swish")]
#endif
        public SessionPaymentMethodOptionsSwish Swish { get; set; }

        [JsonProperty("us_bank_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("us_bank_account")]
#endif
        public SessionPaymentMethodOptionsUsBankAccount UsBankAccount { get; set; }
    }
}
