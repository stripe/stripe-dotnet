// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ChargePaymentMethodDetails : StripeEntity<ChargePaymentMethodDetails>
    {
        [JsonProperty("ach_credit_transfer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ach_credit_transfer")]
#endif
        public ChargePaymentMethodDetailsAchCreditTransfer AchCreditTransfer { get; set; }

        [JsonProperty("ach_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ach_debit")]
#endif
        public ChargePaymentMethodDetailsAchDebit AchDebit { get; set; }

        [JsonProperty("acss_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("acss_debit")]
#endif
        public ChargePaymentMethodDetailsAcssDebit AcssDebit { get; set; }

        [JsonProperty("affirm")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("affirm")]
#endif
        public ChargePaymentMethodDetailsAffirm Affirm { get; set; }

        [JsonProperty("afterpay_clearpay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("afterpay_clearpay")]
#endif
        public ChargePaymentMethodDetailsAfterpayClearpay AfterpayClearpay { get; set; }

        [JsonProperty("alipay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("alipay")]
#endif
        public ChargePaymentMethodDetailsAlipay Alipay { get; set; }

        [JsonProperty("alma")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("alma")]
#endif
        public ChargePaymentMethodDetailsAlma Alma { get; set; }

        [JsonProperty("amazon_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amazon_pay")]
#endif
        public ChargePaymentMethodDetailsAmazonPay AmazonPay { get; set; }

        [JsonProperty("au_becs_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("au_becs_debit")]
#endif
        public ChargePaymentMethodDetailsAuBecsDebit AuBecsDebit { get; set; }

        [JsonProperty("bacs_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bacs_debit")]
#endif
        public ChargePaymentMethodDetailsBacsDebit BacsDebit { get; set; }

        [JsonProperty("bancontact")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bancontact")]
#endif
        public ChargePaymentMethodDetailsBancontact Bancontact { get; set; }

        [JsonProperty("billie")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billie")]
#endif
        public ChargePaymentMethodDetailsBillie Billie { get; set; }

        [JsonProperty("blik")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("blik")]
#endif
        public ChargePaymentMethodDetailsBlik Blik { get; set; }

        [JsonProperty("boleto")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("boleto")]
#endif
        public ChargePaymentMethodDetailsBoleto Boleto { get; set; }

        [JsonProperty("card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card")]
#endif
        public ChargePaymentMethodDetailsCard Card { get; set; }

        [JsonProperty("card_present")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card_present")]
#endif
        public ChargePaymentMethodDetailsCardPresent CardPresent { get; set; }

        [JsonProperty("cashapp")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cashapp")]
#endif
        public ChargePaymentMethodDetailsCashapp Cashapp { get; set; }

        [JsonProperty("crypto")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("crypto")]
#endif
        public ChargePaymentMethodDetailsCrypto Crypto { get; set; }

        [JsonProperty("customer_balance")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_balance")]
#endif
        public ChargePaymentMethodDetailsCustomerBalance CustomerBalance { get; set; }

        [JsonProperty("eps")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("eps")]
#endif
        public ChargePaymentMethodDetailsEps Eps { get; set; }

        [JsonProperty("fpx")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fpx")]
#endif
        public ChargePaymentMethodDetailsFpx Fpx { get; set; }

        [JsonProperty("giropay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("giropay")]
#endif
        public ChargePaymentMethodDetailsGiropay Giropay { get; set; }

        [JsonProperty("gopay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("gopay")]
#endif
        public ChargePaymentMethodDetailsGopay Gopay { get; set; }

        [JsonProperty("grabpay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("grabpay")]
#endif
        public ChargePaymentMethodDetailsGrabpay Grabpay { get; set; }

        [JsonProperty("id_bank_transfer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id_bank_transfer")]
#endif
        public ChargePaymentMethodDetailsIdBankTransfer IdBankTransfer { get; set; }

        [JsonProperty("ideal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ideal")]
#endif
        public ChargePaymentMethodDetailsIdeal Ideal { get; set; }

        [JsonProperty("interac_present")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("interac_present")]
#endif
        public ChargePaymentMethodDetailsInteracPresent InteracPresent { get; set; }

        [JsonProperty("kakao_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("kakao_pay")]
#endif
        public ChargePaymentMethodDetailsKakaoPay KakaoPay { get; set; }

        [JsonProperty("klarna")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("klarna")]
#endif
        public ChargePaymentMethodDetailsKlarna Klarna { get; set; }

        [JsonProperty("konbini")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("konbini")]
#endif
        public ChargePaymentMethodDetailsKonbini Konbini { get; set; }

        [JsonProperty("kr_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("kr_card")]
#endif
        public ChargePaymentMethodDetailsKrCard KrCard { get; set; }

        [JsonProperty("link")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("link")]
#endif
        public ChargePaymentMethodDetailsLink Link { get; set; }

        [JsonProperty("mb_way")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mb_way")]
#endif
        public ChargePaymentMethodDetailsMbWay MbWay { get; set; }

        [JsonProperty("mobilepay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mobilepay")]
#endif
        public ChargePaymentMethodDetailsMobilepay Mobilepay { get; set; }

        [JsonProperty("multibanco")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("multibanco")]
#endif
        public ChargePaymentMethodDetailsMultibanco Multibanco { get; set; }

        [JsonProperty("naver_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("naver_pay")]
#endif
        public ChargePaymentMethodDetailsNaverPay NaverPay { get; set; }

        [JsonProperty("nz_bank_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("nz_bank_account")]
#endif
        public ChargePaymentMethodDetailsNzBankAccount NzBankAccount { get; set; }

        [JsonProperty("oxxo")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("oxxo")]
#endif
        public ChargePaymentMethodDetailsOxxo Oxxo { get; set; }

        [JsonProperty("p24")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("p24")]
#endif
        public ChargePaymentMethodDetailsP24 P24 { get; set; }

        [JsonProperty("pay_by_bank")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pay_by_bank")]
#endif
        public ChargePaymentMethodDetailsPayByBank PayByBank { get; set; }

        [JsonProperty("payco")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payco")]
#endif
        public ChargePaymentMethodDetailsPayco Payco { get; set; }

        [JsonProperty("paynow")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paynow")]
#endif
        public ChargePaymentMethodDetailsPaynow Paynow { get; set; }

        [JsonProperty("paypal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paypal")]
#endif
        public ChargePaymentMethodDetailsPaypal Paypal { get; set; }

        [JsonProperty("paypay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paypay")]
#endif
        public ChargePaymentMethodDetailsPaypay Paypay { get; set; }

        [JsonProperty("payto")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payto")]
#endif
        public ChargePaymentMethodDetailsPayto Payto { get; set; }

        [JsonProperty("pix")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pix")]
#endif
        public ChargePaymentMethodDetailsPix Pix { get; set; }

        [JsonProperty("promptpay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("promptpay")]
#endif
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
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("revolut_pay")]
#endif
        public ChargePaymentMethodDetailsRevolutPay RevolutPay { get; set; }

        [JsonProperty("samsung_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("samsung_pay")]
#endif
        public ChargePaymentMethodDetailsSamsungPay SamsungPay { get; set; }

        [JsonProperty("satispay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("satispay")]
#endif
        public ChargePaymentMethodDetailsSatispay Satispay { get; set; }

        [JsonProperty("sepa_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sepa_debit")]
#endif
        public ChargePaymentMethodDetailsSepaDebit SepaDebit { get; set; }

        [JsonProperty("shopeepay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shopeepay")]
#endif
        public ChargePaymentMethodDetailsShopeepay Shopeepay { get; set; }

        [JsonProperty("sofort")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sofort")]
#endif
        public ChargePaymentMethodDetailsSofort Sofort { get; set; }

        [JsonProperty("stripe_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("stripe_account")]
#endif
        public ChargePaymentMethodDetailsStripeAccount StripeAccount { get; set; }

        [JsonProperty("stripe_balance")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("stripe_balance")]
#endif
        public ChargePaymentMethodDetailsStripeBalance StripeBalance { get; set; }

        [JsonProperty("swish")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("swish")]
#endif
        public ChargePaymentMethodDetailsSwish Swish { get; set; }

        [JsonProperty("twint")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("twint")]
#endif
        public ChargePaymentMethodDetailsTwint Twint { get; set; }

        /// <summary>
        /// The type of transaction-specific details of the payment method used in the payment. See
        /// <a
        /// href="https://stripe.com/docs/api/payment_methods/object#payment_method_object-type">PaymentMethod.type</a>
        /// for the full list of possible types. An additional hash is included on
        /// <c>payment_method_details</c> with a name matching this value. It contains information
        /// specific to the payment method.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        [JsonProperty("us_bank_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("us_bank_account")]
#endif
        public ChargePaymentMethodDetailsUsBankAccount UsBankAccount { get; set; }

        [JsonProperty("wechat")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("wechat")]
#endif
        public ChargePaymentMethodDetailsWechat Wechat { get; set; }

        [JsonProperty("wechat_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("wechat_pay")]
#endif
        public ChargePaymentMethodDetailsWechatPay WechatPay { get; set; }

        [JsonProperty("zip")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("zip")]
#endif
        public ChargePaymentMethodDetailsZip Zip { get; set; }
    }
}
