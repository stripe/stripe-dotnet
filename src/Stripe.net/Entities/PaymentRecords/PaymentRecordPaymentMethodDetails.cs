// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentRecordPaymentMethodDetails : StripeEntity<PaymentRecordPaymentMethodDetails>
    {
        [JsonProperty("ach_credit_transfer")]
        [STJS.JsonPropertyName("ach_credit_transfer")]
        public PaymentRecordPaymentMethodDetailsAchCreditTransfer AchCreditTransfer { get; set; }

        [JsonProperty("ach_debit")]
        [STJS.JsonPropertyName("ach_debit")]
        public PaymentRecordPaymentMethodDetailsAchDebit AchDebit { get; set; }

        [JsonProperty("acss_debit")]
        [STJS.JsonPropertyName("acss_debit")]
        public PaymentRecordPaymentMethodDetailsAcssDebit AcssDebit { get; set; }

        [JsonProperty("affirm")]
        [STJS.JsonPropertyName("affirm")]
        public PaymentRecordPaymentMethodDetailsAffirm Affirm { get; set; }

        [JsonProperty("afterpay_clearpay")]
        [STJS.JsonPropertyName("afterpay_clearpay")]
        public PaymentRecordPaymentMethodDetailsAfterpayClearpay AfterpayClearpay { get; set; }

        [JsonProperty("alipay")]
        [STJS.JsonPropertyName("alipay")]
        public PaymentRecordPaymentMethodDetailsAlipay Alipay { get; set; }

        [JsonProperty("alma")]
        [STJS.JsonPropertyName("alma")]
        public PaymentRecordPaymentMethodDetailsAlma Alma { get; set; }

        [JsonProperty("amazon_pay")]
        [STJS.JsonPropertyName("amazon_pay")]
        public PaymentRecordPaymentMethodDetailsAmazonPay AmazonPay { get; set; }

        [JsonProperty("au_becs_debit")]
        [STJS.JsonPropertyName("au_becs_debit")]
        public PaymentRecordPaymentMethodDetailsAuBecsDebit AuBecsDebit { get; set; }

        [JsonProperty("bacs_debit")]
        [STJS.JsonPropertyName("bacs_debit")]
        public PaymentRecordPaymentMethodDetailsBacsDebit BacsDebit { get; set; }

        [JsonProperty("bancontact")]
        [STJS.JsonPropertyName("bancontact")]
        public PaymentRecordPaymentMethodDetailsBancontact Bancontact { get; set; }

        [JsonProperty("billie")]
        [STJS.JsonPropertyName("billie")]
        public PaymentRecordPaymentMethodDetailsBillie Billie { get; set; }

        /// <summary>
        /// The billing details associated with the method of payment.
        /// </summary>
        [JsonProperty("billing_details")]
        [STJS.JsonPropertyName("billing_details")]
        public PaymentRecordPaymentMethodDetailsBillingDetails BillingDetails { get; set; }

        [JsonProperty("blik")]
        [STJS.JsonPropertyName("blik")]
        public PaymentRecordPaymentMethodDetailsBlik Blik { get; set; }

        [JsonProperty("boleto")]
        [STJS.JsonPropertyName("boleto")]
        public PaymentRecordPaymentMethodDetailsBoleto Boleto { get; set; }

        /// <summary>
        /// Details of the card used for this payment attempt.
        /// </summary>
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public PaymentRecordPaymentMethodDetailsCard Card { get; set; }

        [JsonProperty("card_present")]
        [STJS.JsonPropertyName("card_present")]
        public PaymentRecordPaymentMethodDetailsCardPresent CardPresent { get; set; }

        [JsonProperty("cashapp")]
        [STJS.JsonPropertyName("cashapp")]
        public PaymentRecordPaymentMethodDetailsCashapp Cashapp { get; set; }

        [JsonProperty("crypto")]
        [STJS.JsonPropertyName("crypto")]
        public PaymentRecordPaymentMethodDetailsCrypto Crypto { get; set; }

        /// <summary>
        /// Custom Payment Methods represent Payment Method types not modeled directly in the Stripe
        /// API. This resource consists of details about the custom payment method used for this
        /// payment attempt.
        /// </summary>
        [JsonProperty("custom")]
        [STJS.JsonPropertyName("custom")]
        public PaymentRecordPaymentMethodDetailsCustom Custom { get; set; }

        [JsonProperty("customer_balance")]
        [STJS.JsonPropertyName("customer_balance")]
        public PaymentRecordPaymentMethodDetailsCustomerBalance CustomerBalance { get; set; }

        [JsonProperty("eps")]
        [STJS.JsonPropertyName("eps")]
        public PaymentRecordPaymentMethodDetailsEps Eps { get; set; }

        [JsonProperty("fpx")]
        [STJS.JsonPropertyName("fpx")]
        public PaymentRecordPaymentMethodDetailsFpx Fpx { get; set; }

        [JsonProperty("gift_card")]
        [STJS.JsonPropertyName("gift_card")]
        public PaymentRecordPaymentMethodDetailsGiftCard GiftCard { get; set; }

        [JsonProperty("giropay")]
        [STJS.JsonPropertyName("giropay")]
        public PaymentRecordPaymentMethodDetailsGiropay Giropay { get; set; }

        [JsonProperty("gopay")]
        [STJS.JsonPropertyName("gopay")]
        public PaymentRecordPaymentMethodDetailsGopay Gopay { get; set; }

        [JsonProperty("grabpay")]
        [STJS.JsonPropertyName("grabpay")]
        public PaymentRecordPaymentMethodDetailsGrabpay Grabpay { get; set; }

        [JsonProperty("id_bank_transfer")]
        [STJS.JsonPropertyName("id_bank_transfer")]
        public PaymentRecordPaymentMethodDetailsIdBankTransfer IdBankTransfer { get; set; }

        [JsonProperty("ideal")]
        [STJS.JsonPropertyName("ideal")]
        public PaymentRecordPaymentMethodDetailsIdeal Ideal { get; set; }

        [JsonProperty("interac_present")]
        [STJS.JsonPropertyName("interac_present")]
        public PaymentRecordPaymentMethodDetailsInteracPresent InteracPresent { get; set; }

        [JsonProperty("kakao_pay")]
        [STJS.JsonPropertyName("kakao_pay")]
        public PaymentRecordPaymentMethodDetailsKakaoPay KakaoPay { get; set; }

        [JsonProperty("klarna")]
        [STJS.JsonPropertyName("klarna")]
        public PaymentRecordPaymentMethodDetailsKlarna Klarna { get; set; }

        [JsonProperty("konbini")]
        [STJS.JsonPropertyName("konbini")]
        public PaymentRecordPaymentMethodDetailsKonbini Konbini { get; set; }

        [JsonProperty("kr_card")]
        [STJS.JsonPropertyName("kr_card")]
        public PaymentRecordPaymentMethodDetailsKrCard KrCard { get; set; }

        [JsonProperty("link")]
        [STJS.JsonPropertyName("link")]
        public PaymentRecordPaymentMethodDetailsLink Link { get; set; }

        [JsonProperty("mb_way")]
        [STJS.JsonPropertyName("mb_way")]
        public PaymentRecordPaymentMethodDetailsMbWay MbWay { get; set; }

        [JsonProperty("mobilepay")]
        [STJS.JsonPropertyName("mobilepay")]
        public PaymentRecordPaymentMethodDetailsMobilepay Mobilepay { get; set; }

        [JsonProperty("multibanco")]
        [STJS.JsonPropertyName("multibanco")]
        public PaymentRecordPaymentMethodDetailsMultibanco Multibanco { get; set; }

        [JsonProperty("naver_pay")]
        [STJS.JsonPropertyName("naver_pay")]
        public PaymentRecordPaymentMethodDetailsNaverPay NaverPay { get; set; }

        [JsonProperty("nz_bank_account")]
        [STJS.JsonPropertyName("nz_bank_account")]
        public PaymentRecordPaymentMethodDetailsNzBankAccount NzBankAccount { get; set; }

        [JsonProperty("oxxo")]
        [STJS.JsonPropertyName("oxxo")]
        public PaymentRecordPaymentMethodDetailsOxxo Oxxo { get; set; }

        [JsonProperty("p24")]
        [STJS.JsonPropertyName("p24")]
        public PaymentRecordPaymentMethodDetailsP24 P24 { get; set; }

        [JsonProperty("pay_by_bank")]
        [STJS.JsonPropertyName("pay_by_bank")]
        public PaymentRecordPaymentMethodDetailsPayByBank PayByBank { get; set; }

        [JsonProperty("payco")]
        [STJS.JsonPropertyName("payco")]
        public PaymentRecordPaymentMethodDetailsPayco Payco { get; set; }

        /// <summary>
        /// ID of the Stripe PaymentMethod used to make this payment.
        /// </summary>
        [JsonProperty("payment_method")]
        [STJS.JsonPropertyName("payment_method")]
        public string PaymentMethod { get; set; }

        [JsonProperty("paynow")]
        [STJS.JsonPropertyName("paynow")]
        public PaymentRecordPaymentMethodDetailsPaynow Paynow { get; set; }

        [JsonProperty("paypal")]
        [STJS.JsonPropertyName("paypal")]
        public PaymentRecordPaymentMethodDetailsPaypal Paypal { get; set; }

        [JsonProperty("paypay")]
        [STJS.JsonPropertyName("paypay")]
        public PaymentRecordPaymentMethodDetailsPaypay Paypay { get; set; }

        [JsonProperty("payto")]
        [STJS.JsonPropertyName("payto")]
        public PaymentRecordPaymentMethodDetailsPayto Payto { get; set; }

        [JsonProperty("pix")]
        [STJS.JsonPropertyName("pix")]
        public PaymentRecordPaymentMethodDetailsPix Pix { get; set; }

        [JsonProperty("promptpay")]
        [STJS.JsonPropertyName("promptpay")]
        public PaymentRecordPaymentMethodDetailsPromptpay Promptpay { get; set; }

        [JsonProperty("qris")]
        [STJS.JsonPropertyName("qris")]
        public PaymentRecordPaymentMethodDetailsQris Qris { get; set; }

        [JsonProperty("rechnung")]
        [STJS.JsonPropertyName("rechnung")]
        public PaymentRecordPaymentMethodDetailsRechnung Rechnung { get; set; }

        [JsonProperty("revolut_pay")]
        [STJS.JsonPropertyName("revolut_pay")]
        public PaymentRecordPaymentMethodDetailsRevolutPay RevolutPay { get; set; }

        [JsonProperty("samsung_pay")]
        [STJS.JsonPropertyName("samsung_pay")]
        public PaymentRecordPaymentMethodDetailsSamsungPay SamsungPay { get; set; }

        [JsonProperty("satispay")]
        [STJS.JsonPropertyName("satispay")]
        public PaymentRecordPaymentMethodDetailsSatispay Satispay { get; set; }

        [JsonProperty("sepa_credit_transfer")]
        [STJS.JsonPropertyName("sepa_credit_transfer")]
        public PaymentRecordPaymentMethodDetailsSepaCreditTransfer SepaCreditTransfer { get; set; }

        [JsonProperty("sepa_debit")]
        [STJS.JsonPropertyName("sepa_debit")]
        public PaymentRecordPaymentMethodDetailsSepaDebit SepaDebit { get; set; }

        [JsonProperty("shopeepay")]
        [STJS.JsonPropertyName("shopeepay")]
        public PaymentRecordPaymentMethodDetailsShopeepay Shopeepay { get; set; }

        [JsonProperty("sofort")]
        [STJS.JsonPropertyName("sofort")]
        public PaymentRecordPaymentMethodDetailsSofort Sofort { get; set; }

        [JsonProperty("stripe_account")]
        [STJS.JsonPropertyName("stripe_account")]
        public PaymentRecordPaymentMethodDetailsStripeAccount StripeAccount { get; set; }

        [JsonProperty("stripe_balance")]
        [STJS.JsonPropertyName("stripe_balance")]
        public PaymentRecordPaymentMethodDetailsStripeBalance StripeBalance { get; set; }

        [JsonProperty("swish")]
        [STJS.JsonPropertyName("swish")]
        public PaymentRecordPaymentMethodDetailsSwish Swish { get; set; }

        [JsonProperty("twint")]
        [STJS.JsonPropertyName("twint")]
        public PaymentRecordPaymentMethodDetailsTwint Twint { get; set; }

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

        [JsonProperty("upi")]
        [STJS.JsonPropertyName("upi")]
        public PaymentRecordPaymentMethodDetailsUpi Upi { get; set; }

        [JsonProperty("us_bank_account")]
        [STJS.JsonPropertyName("us_bank_account")]
        public PaymentRecordPaymentMethodDetailsUsBankAccount UsBankAccount { get; set; }

        [JsonProperty("wechat")]
        [STJS.JsonPropertyName("wechat")]
        public PaymentRecordPaymentMethodDetailsWechat Wechat { get; set; }

        [JsonProperty("wechat_pay")]
        [STJS.JsonPropertyName("wechat_pay")]
        public PaymentRecordPaymentMethodDetailsWechatPay WechatPay { get; set; }

        [JsonProperty("zip")]
        [STJS.JsonPropertyName("zip")]
        public PaymentRecordPaymentMethodDetailsZip Zip { get; set; }
    }
}
