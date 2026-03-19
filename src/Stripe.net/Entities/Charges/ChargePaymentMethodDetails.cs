// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ChargePaymentMethodDetails : StripeEntity<ChargePaymentMethodDetails>
    {
        [JsonProperty("ach_credit_transfer")]
        [STJS.JsonPropertyName("ach_credit_transfer")]
        public ChargePaymentMethodDetailsAchCreditTransfer AchCreditTransfer { get; set; }

        [JsonProperty("ach_debit")]
        [STJS.JsonPropertyName("ach_debit")]
        public ChargePaymentMethodDetailsAchDebit AchDebit { get; set; }

        [JsonProperty("acss_debit")]
        [STJS.JsonPropertyName("acss_debit")]
        public ChargePaymentMethodDetailsAcssDebit AcssDebit { get; set; }

        [JsonProperty("affirm")]
        [STJS.JsonPropertyName("affirm")]
        public ChargePaymentMethodDetailsAffirm Affirm { get; set; }

        [JsonProperty("afterpay_clearpay")]
        [STJS.JsonPropertyName("afterpay_clearpay")]
        public ChargePaymentMethodDetailsAfterpayClearpay AfterpayClearpay { get; set; }

        [JsonProperty("alipay")]
        [STJS.JsonPropertyName("alipay")]
        public ChargePaymentMethodDetailsAlipay Alipay { get; set; }

        [JsonProperty("alma")]
        [STJS.JsonPropertyName("alma")]
        public ChargePaymentMethodDetailsAlma Alma { get; set; }

        [JsonProperty("amazon_pay")]
        [STJS.JsonPropertyName("amazon_pay")]
        public ChargePaymentMethodDetailsAmazonPay AmazonPay { get; set; }

        [JsonProperty("au_becs_debit")]
        [STJS.JsonPropertyName("au_becs_debit")]
        public ChargePaymentMethodDetailsAuBecsDebit AuBecsDebit { get; set; }

        [JsonProperty("bacs_debit")]
        [STJS.JsonPropertyName("bacs_debit")]
        public ChargePaymentMethodDetailsBacsDebit BacsDebit { get; set; }

        [JsonProperty("bancontact")]
        [STJS.JsonPropertyName("bancontact")]
        public ChargePaymentMethodDetailsBancontact Bancontact { get; set; }

        [JsonProperty("billie")]
        [STJS.JsonPropertyName("billie")]
        public ChargePaymentMethodDetailsBillie Billie { get; set; }

        [JsonProperty("blik")]
        [STJS.JsonPropertyName("blik")]
        public ChargePaymentMethodDetailsBlik Blik { get; set; }

        [JsonProperty("boleto")]
        [STJS.JsonPropertyName("boleto")]
        public ChargePaymentMethodDetailsBoleto Boleto { get; set; }

        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public ChargePaymentMethodDetailsCard Card { get; set; }

        [JsonProperty("card_present")]
        [STJS.JsonPropertyName("card_present")]
        public ChargePaymentMethodDetailsCardPresent CardPresent { get; set; }

        [JsonProperty("cashapp")]
        [STJS.JsonPropertyName("cashapp")]
        public ChargePaymentMethodDetailsCashapp Cashapp { get; set; }

        [JsonProperty("crypto")]
        [STJS.JsonPropertyName("crypto")]
        public ChargePaymentMethodDetailsCrypto Crypto { get; set; }

        [JsonProperty("customer_balance")]
        [STJS.JsonPropertyName("customer_balance")]
        public ChargePaymentMethodDetailsCustomerBalance CustomerBalance { get; set; }

        [JsonProperty("eps")]
        [STJS.JsonPropertyName("eps")]
        public ChargePaymentMethodDetailsEps Eps { get; set; }

        [JsonProperty("fpx")]
        [STJS.JsonPropertyName("fpx")]
        public ChargePaymentMethodDetailsFpx Fpx { get; set; }

        [JsonProperty("giropay")]
        [STJS.JsonPropertyName("giropay")]
        public ChargePaymentMethodDetailsGiropay Giropay { get; set; }

        [JsonProperty("gopay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("gopay")]
#endif
        public ChargePaymentMethodDetailsGopay Gopay { get; set; }

        [JsonProperty("grabpay")]
        [STJS.JsonPropertyName("grabpay")]
        public ChargePaymentMethodDetailsGrabpay Grabpay { get; set; }

        [JsonProperty("id_bank_transfer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id_bank_transfer")]
#endif
        public ChargePaymentMethodDetailsIdBankTransfer IdBankTransfer { get; set; }

        [JsonProperty("ideal")]
        [STJS.JsonPropertyName("ideal")]
        public ChargePaymentMethodDetailsIdeal Ideal { get; set; }

        [JsonProperty("interac_present")]
        [STJS.JsonPropertyName("interac_present")]
        public ChargePaymentMethodDetailsInteracPresent InteracPresent { get; set; }

        [JsonProperty("kakao_pay")]
        [STJS.JsonPropertyName("kakao_pay")]
        public ChargePaymentMethodDetailsKakaoPay KakaoPay { get; set; }

        [JsonProperty("klarna")]
        [STJS.JsonPropertyName("klarna")]
        public ChargePaymentMethodDetailsKlarna Klarna { get; set; }

        [JsonProperty("konbini")]
        [STJS.JsonPropertyName("konbini")]
        public ChargePaymentMethodDetailsKonbini Konbini { get; set; }

        [JsonProperty("kr_card")]
        [STJS.JsonPropertyName("kr_card")]
        public ChargePaymentMethodDetailsKrCard KrCard { get; set; }

        [JsonProperty("link")]
        [STJS.JsonPropertyName("link")]
        public ChargePaymentMethodDetailsLink Link { get; set; }

        [JsonProperty("mb_way")]
        [STJS.JsonPropertyName("mb_way")]
        public ChargePaymentMethodDetailsMbWay MbWay { get; set; }

        [JsonProperty("mobilepay")]
        [STJS.JsonPropertyName("mobilepay")]
        public ChargePaymentMethodDetailsMobilepay Mobilepay { get; set; }

        [JsonProperty("multibanco")]
        [STJS.JsonPropertyName("multibanco")]
        public ChargePaymentMethodDetailsMultibanco Multibanco { get; set; }

        [JsonProperty("naver_pay")]
        [STJS.JsonPropertyName("naver_pay")]
        public ChargePaymentMethodDetailsNaverPay NaverPay { get; set; }

        [JsonProperty("nz_bank_account")]
        [STJS.JsonPropertyName("nz_bank_account")]
        public ChargePaymentMethodDetailsNzBankAccount NzBankAccount { get; set; }

        [JsonProperty("oxxo")]
        [STJS.JsonPropertyName("oxxo")]
        public ChargePaymentMethodDetailsOxxo Oxxo { get; set; }

        [JsonProperty("p24")]
        [STJS.JsonPropertyName("p24")]
        public ChargePaymentMethodDetailsP24 P24 { get; set; }

        [JsonProperty("pay_by_bank")]
        [STJS.JsonPropertyName("pay_by_bank")]
        public ChargePaymentMethodDetailsPayByBank PayByBank { get; set; }

        [JsonProperty("payco")]
        [STJS.JsonPropertyName("payco")]
        public ChargePaymentMethodDetailsPayco Payco { get; set; }

        [JsonProperty("paynow")]
        [STJS.JsonPropertyName("paynow")]
        public ChargePaymentMethodDetailsPaynow Paynow { get; set; }

        [JsonProperty("paypal")]
        [STJS.JsonPropertyName("paypal")]
        public ChargePaymentMethodDetailsPaypal Paypal { get; set; }

        [JsonProperty("paypay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paypay")]
#endif
        public ChargePaymentMethodDetailsPaypay Paypay { get; set; }

        [JsonProperty("payto")]
        [STJS.JsonPropertyName("payto")]
        public ChargePaymentMethodDetailsPayto Payto { get; set; }

        [JsonProperty("pix")]
        [STJS.JsonPropertyName("pix")]
        public ChargePaymentMethodDetailsPix Pix { get; set; }

        [JsonProperty("promptpay")]
        [STJS.JsonPropertyName("promptpay")]
        public ChargePaymentMethodDetailsPromptpay Promptpay { get; set; }

        [JsonProperty("qris")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("qris")]
#endif
        public ChargePaymentMethodDetailsQris Qris { get; set; }

        [JsonProperty("rechnung")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rechnung")]
#endif
        public ChargePaymentMethodDetailsRechnung Rechnung { get; set; }

        [JsonProperty("revolut_pay")]
        [STJS.JsonPropertyName("revolut_pay")]
        public ChargePaymentMethodDetailsRevolutPay RevolutPay { get; set; }

        [JsonProperty("samsung_pay")]
        [STJS.JsonPropertyName("samsung_pay")]
        public ChargePaymentMethodDetailsSamsungPay SamsungPay { get; set; }

        [JsonProperty("satispay")]
        [STJS.JsonPropertyName("satispay")]
        public ChargePaymentMethodDetailsSatispay Satispay { get; set; }

        [JsonProperty("sepa_debit")]
        [STJS.JsonPropertyName("sepa_debit")]
        public ChargePaymentMethodDetailsSepaDebit SepaDebit { get; set; }

        [JsonProperty("shopeepay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shopeepay")]
#endif
        public ChargePaymentMethodDetailsShopeepay Shopeepay { get; set; }

        [JsonProperty("sofort")]
        [STJS.JsonPropertyName("sofort")]
        public ChargePaymentMethodDetailsSofort Sofort { get; set; }

        [JsonProperty("stripe_account")]
        [STJS.JsonPropertyName("stripe_account")]
        public ChargePaymentMethodDetailsStripeAccount StripeAccount { get; set; }

        [JsonProperty("stripe_balance")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("stripe_balance")]
#endif
        public ChargePaymentMethodDetailsStripeBalance StripeBalance { get; set; }

        [JsonProperty("swish")]
        [STJS.JsonPropertyName("swish")]
        public ChargePaymentMethodDetailsSwish Swish { get; set; }

        [JsonProperty("twint")]
        [STJS.JsonPropertyName("twint")]
        public ChargePaymentMethodDetailsTwint Twint { get; set; }

        /// <summary>
        /// The type of transaction-specific details of the payment method used in the payment. See
        /// <a
        /// href="https://docs.stripe.com/api/payment_methods/object#payment_method_object-type">PaymentMethod.type</a>
        /// for the full list of possible types. An additional hash is included on
        /// <c>payment_method_details</c> with a name matching this value. It contains information
        /// specific to the payment method.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonProperty("us_bank_account")]
        [STJS.JsonPropertyName("us_bank_account")]
        public ChargePaymentMethodDetailsUsBankAccount UsBankAccount { get; set; }

        [JsonProperty("wechat")]
        [STJS.JsonPropertyName("wechat")]
        public ChargePaymentMethodDetailsWechat Wechat { get; set; }

        [JsonProperty("wechat_pay")]
        [STJS.JsonPropertyName("wechat_pay")]
        public ChargePaymentMethodDetailsWechatPay WechatPay { get; set; }

        [JsonProperty("zip")]
        [STJS.JsonPropertyName("zip")]
        public ChargePaymentMethodDetailsZip Zip { get; set; }
    }
}
