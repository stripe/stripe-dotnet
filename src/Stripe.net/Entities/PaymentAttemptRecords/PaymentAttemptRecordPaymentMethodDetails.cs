// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentAttemptRecordPaymentMethodDetails : StripeEntity<PaymentAttemptRecordPaymentMethodDetails>
    {
        [JsonProperty("ach_credit_transfer")]
        [STJS.JsonPropertyName("ach_credit_transfer")]
        public PaymentAttemptRecordPaymentMethodDetailsAchCreditTransfer AchCreditTransfer { get; set; }

        [JsonProperty("ach_debit")]
        [STJS.JsonPropertyName("ach_debit")]
        public PaymentAttemptRecordPaymentMethodDetailsAchDebit AchDebit { get; set; }

        [JsonProperty("acss_debit")]
        [STJS.JsonPropertyName("acss_debit")]
        public PaymentAttemptRecordPaymentMethodDetailsAcssDebit AcssDebit { get; set; }

        [JsonProperty("affirm")]
        [STJS.JsonPropertyName("affirm")]
        public PaymentAttemptRecordPaymentMethodDetailsAffirm Affirm { get; set; }

        [JsonProperty("afterpay_clearpay")]
        [STJS.JsonPropertyName("afterpay_clearpay")]
        public PaymentAttemptRecordPaymentMethodDetailsAfterpayClearpay AfterpayClearpay { get; set; }

        [JsonProperty("alipay")]
        [STJS.JsonPropertyName("alipay")]
        public PaymentAttemptRecordPaymentMethodDetailsAlipay Alipay { get; set; }

        [JsonProperty("alma")]
        [STJS.JsonPropertyName("alma")]
        public PaymentAttemptRecordPaymentMethodDetailsAlma Alma { get; set; }

        [JsonProperty("amazon_pay")]
        [STJS.JsonPropertyName("amazon_pay")]
        public PaymentAttemptRecordPaymentMethodDetailsAmazonPay AmazonPay { get; set; }

        [JsonProperty("au_becs_debit")]
        [STJS.JsonPropertyName("au_becs_debit")]
        public PaymentAttemptRecordPaymentMethodDetailsAuBecsDebit AuBecsDebit { get; set; }

        [JsonProperty("bacs_debit")]
        [STJS.JsonPropertyName("bacs_debit")]
        public PaymentAttemptRecordPaymentMethodDetailsBacsDebit BacsDebit { get; set; }

        [JsonProperty("bancontact")]
        [STJS.JsonPropertyName("bancontact")]
        public PaymentAttemptRecordPaymentMethodDetailsBancontact Bancontact { get; set; }

        [JsonProperty("billie")]
        [STJS.JsonPropertyName("billie")]
        public PaymentAttemptRecordPaymentMethodDetailsBillie Billie { get; set; }

        /// <summary>
        /// The billing details associated with the method of payment.
        /// </summary>
        [JsonProperty("billing_details")]
        [STJS.JsonPropertyName("billing_details")]
        public PaymentAttemptRecordPaymentMethodDetailsBillingDetails BillingDetails { get; set; }

        [JsonProperty("blik")]
        [STJS.JsonPropertyName("blik")]
        public PaymentAttemptRecordPaymentMethodDetailsBlik Blik { get; set; }

        [JsonProperty("boleto")]
        [STJS.JsonPropertyName("boleto")]
        public PaymentAttemptRecordPaymentMethodDetailsBoleto Boleto { get; set; }

        /// <summary>
        /// Details of the card used for this payment attempt.
        /// </summary>
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public PaymentAttemptRecordPaymentMethodDetailsCard Card { get; set; }

        [JsonProperty("card_present")]
        [STJS.JsonPropertyName("card_present")]
        public PaymentAttemptRecordPaymentMethodDetailsCardPresent CardPresent { get; set; }

        [JsonProperty("cashapp")]
        [STJS.JsonPropertyName("cashapp")]
        public PaymentAttemptRecordPaymentMethodDetailsCashapp Cashapp { get; set; }

        [JsonProperty("crypto")]
        [STJS.JsonPropertyName("crypto")]
        public PaymentAttemptRecordPaymentMethodDetailsCrypto Crypto { get; set; }

        /// <summary>
        /// Custom Payment Methods represent Payment Method types not modeled directly in the Stripe
        /// API. This resource consists of details about the custom payment method used for this
        /// payment attempt.
        /// </summary>
        [JsonProperty("custom")]
        [STJS.JsonPropertyName("custom")]
        public PaymentAttemptRecordPaymentMethodDetailsCustom Custom { get; set; }

        [JsonProperty("customer_balance")]
        [STJS.JsonPropertyName("customer_balance")]
        public PaymentAttemptRecordPaymentMethodDetailsCustomerBalance CustomerBalance { get; set; }

        [JsonProperty("eps")]
        [STJS.JsonPropertyName("eps")]
        public PaymentAttemptRecordPaymentMethodDetailsEps Eps { get; set; }

        [JsonProperty("fpx")]
        [STJS.JsonPropertyName("fpx")]
        public PaymentAttemptRecordPaymentMethodDetailsFpx Fpx { get; set; }

        [JsonProperty("giropay")]
        [STJS.JsonPropertyName("giropay")]
        public PaymentAttemptRecordPaymentMethodDetailsGiropay Giropay { get; set; }

        [JsonProperty("gopay")]
        [STJS.JsonPropertyName("gopay")]
        public PaymentAttemptRecordPaymentMethodDetailsGopay Gopay { get; set; }

        [JsonProperty("grabpay")]
        [STJS.JsonPropertyName("grabpay")]
        public PaymentAttemptRecordPaymentMethodDetailsGrabpay Grabpay { get; set; }

        [JsonProperty("id_bank_transfer")]
        [STJS.JsonPropertyName("id_bank_transfer")]
        public PaymentAttemptRecordPaymentMethodDetailsIdBankTransfer IdBankTransfer { get; set; }

        [JsonProperty("ideal")]
        [STJS.JsonPropertyName("ideal")]
        public PaymentAttemptRecordPaymentMethodDetailsIdeal Ideal { get; set; }

        [JsonProperty("interac_present")]
        [STJS.JsonPropertyName("interac_present")]
        public PaymentAttemptRecordPaymentMethodDetailsInteracPresent InteracPresent { get; set; }

        [JsonProperty("kakao_pay")]
        [STJS.JsonPropertyName("kakao_pay")]
        public PaymentAttemptRecordPaymentMethodDetailsKakaoPay KakaoPay { get; set; }

        [JsonProperty("klarna")]
        [STJS.JsonPropertyName("klarna")]
        public PaymentAttemptRecordPaymentMethodDetailsKlarna Klarna { get; set; }

        [JsonProperty("konbini")]
        [STJS.JsonPropertyName("konbini")]
        public PaymentAttemptRecordPaymentMethodDetailsKonbini Konbini { get; set; }

        [JsonProperty("kr_card")]
        [STJS.JsonPropertyName("kr_card")]
        public PaymentAttemptRecordPaymentMethodDetailsKrCard KrCard { get; set; }

        [JsonProperty("link")]
        [STJS.JsonPropertyName("link")]
        public PaymentAttemptRecordPaymentMethodDetailsLink Link { get; set; }

        [JsonProperty("mb_way")]
        [STJS.JsonPropertyName("mb_way")]
        public PaymentAttemptRecordPaymentMethodDetailsMbWay MbWay { get; set; }

        [JsonProperty("mobilepay")]
        [STJS.JsonPropertyName("mobilepay")]
        public PaymentAttemptRecordPaymentMethodDetailsMobilepay Mobilepay { get; set; }

        [JsonProperty("multibanco")]
        [STJS.JsonPropertyName("multibanco")]
        public PaymentAttemptRecordPaymentMethodDetailsMultibanco Multibanco { get; set; }

        [JsonProperty("naver_pay")]
        [STJS.JsonPropertyName("naver_pay")]
        public PaymentAttemptRecordPaymentMethodDetailsNaverPay NaverPay { get; set; }

        [JsonProperty("nz_bank_account")]
        [STJS.JsonPropertyName("nz_bank_account")]
        public PaymentAttemptRecordPaymentMethodDetailsNzBankAccount NzBankAccount { get; set; }

        [JsonProperty("oxxo")]
        [STJS.JsonPropertyName("oxxo")]
        public PaymentAttemptRecordPaymentMethodDetailsOxxo Oxxo { get; set; }

        [JsonProperty("p24")]
        [STJS.JsonPropertyName("p24")]
        public PaymentAttemptRecordPaymentMethodDetailsP24 P24 { get; set; }

        [JsonProperty("pay_by_bank")]
        [STJS.JsonPropertyName("pay_by_bank")]
        public PaymentAttemptRecordPaymentMethodDetailsPayByBank PayByBank { get; set; }

        [JsonProperty("payco")]
        [STJS.JsonPropertyName("payco")]
        public PaymentAttemptRecordPaymentMethodDetailsPayco Payco { get; set; }

        /// <summary>
        /// ID of the Stripe PaymentMethod used to make this payment.
        /// </summary>
        [JsonProperty("payment_method")]
        [STJS.JsonPropertyName("payment_method")]
        public string PaymentMethod { get; set; }

        [JsonProperty("paynow")]
        [STJS.JsonPropertyName("paynow")]
        public PaymentAttemptRecordPaymentMethodDetailsPaynow Paynow { get; set; }

        [JsonProperty("paypal")]
        [STJS.JsonPropertyName("paypal")]
        public PaymentAttemptRecordPaymentMethodDetailsPaypal Paypal { get; set; }

        [JsonProperty("paypay")]
        [STJS.JsonPropertyName("paypay")]
        public PaymentAttemptRecordPaymentMethodDetailsPaypay Paypay { get; set; }

        [JsonProperty("payto")]
        [STJS.JsonPropertyName("payto")]
        public PaymentAttemptRecordPaymentMethodDetailsPayto Payto { get; set; }

        [JsonProperty("pix")]
        [STJS.JsonPropertyName("pix")]
        public PaymentAttemptRecordPaymentMethodDetailsPix Pix { get; set; }

        [JsonProperty("promptpay")]
        [STJS.JsonPropertyName("promptpay")]
        public PaymentAttemptRecordPaymentMethodDetailsPromptpay Promptpay { get; set; }

        [JsonProperty("qris")]
        [STJS.JsonPropertyName("qris")]
        public PaymentAttemptRecordPaymentMethodDetailsQris Qris { get; set; }

        [JsonProperty("rechnung")]
        [STJS.JsonPropertyName("rechnung")]
        public PaymentAttemptRecordPaymentMethodDetailsRechnung Rechnung { get; set; }

        [JsonProperty("revolut_pay")]
        [STJS.JsonPropertyName("revolut_pay")]
        public PaymentAttemptRecordPaymentMethodDetailsRevolutPay RevolutPay { get; set; }

        [JsonProperty("samsung_pay")]
        [STJS.JsonPropertyName("samsung_pay")]
        public PaymentAttemptRecordPaymentMethodDetailsSamsungPay SamsungPay { get; set; }

        [JsonProperty("satispay")]
        [STJS.JsonPropertyName("satispay")]
        public PaymentAttemptRecordPaymentMethodDetailsSatispay Satispay { get; set; }

        [JsonProperty("sepa_credit_transfer")]
        [STJS.JsonPropertyName("sepa_credit_transfer")]
        public PaymentAttemptRecordPaymentMethodDetailsSepaCreditTransfer SepaCreditTransfer { get; set; }

        [JsonProperty("sepa_debit")]
        [STJS.JsonPropertyName("sepa_debit")]
        public PaymentAttemptRecordPaymentMethodDetailsSepaDebit SepaDebit { get; set; }

        [JsonProperty("shopeepay")]
        [STJS.JsonPropertyName("shopeepay")]
        public PaymentAttemptRecordPaymentMethodDetailsShopeepay Shopeepay { get; set; }

        [JsonProperty("sofort")]
        [STJS.JsonPropertyName("sofort")]
        public PaymentAttemptRecordPaymentMethodDetailsSofort Sofort { get; set; }

        [JsonProperty("stripe_account")]
        [STJS.JsonPropertyName("stripe_account")]
        public PaymentAttemptRecordPaymentMethodDetailsStripeAccount StripeAccount { get; set; }

        [JsonProperty("stripe_balance")]
        [STJS.JsonPropertyName("stripe_balance")]
        public PaymentAttemptRecordPaymentMethodDetailsStripeBalance StripeBalance { get; set; }

        [JsonProperty("swish")]
        [STJS.JsonPropertyName("swish")]
        public PaymentAttemptRecordPaymentMethodDetailsSwish Swish { get; set; }

        [JsonProperty("twint")]
        [STJS.JsonPropertyName("twint")]
        public PaymentAttemptRecordPaymentMethodDetailsTwint Twint { get; set; }

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
        public PaymentAttemptRecordPaymentMethodDetailsUsBankAccount UsBankAccount { get; set; }

        [JsonProperty("wechat")]
        [STJS.JsonPropertyName("wechat")]
        public PaymentAttemptRecordPaymentMethodDetailsWechat Wechat { get; set; }

        [JsonProperty("wechat_pay")]
        [STJS.JsonPropertyName("wechat_pay")]
        public PaymentAttemptRecordPaymentMethodDetailsWechatPay WechatPay { get; set; }

        [JsonProperty("zip")]
        [STJS.JsonPropertyName("zip")]
        public PaymentAttemptRecordPaymentMethodDetailsZip Zip { get; set; }
    }
}
