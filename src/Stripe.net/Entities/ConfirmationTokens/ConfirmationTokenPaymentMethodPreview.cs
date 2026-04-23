// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ConfirmationTokenPaymentMethodPreview : StripeEntity<ConfirmationTokenPaymentMethodPreview>
    {
        [JsonProperty("acss_debit")]
        [STJS.JsonPropertyName("acss_debit")]
        public ConfirmationTokenPaymentMethodPreviewAcssDebit AcssDebit { get; set; }

        [JsonProperty("affirm")]
        [STJS.JsonPropertyName("affirm")]
        public ConfirmationTokenPaymentMethodPreviewAffirm Affirm { get; set; }

        [JsonProperty("afterpay_clearpay")]
        [STJS.JsonPropertyName("afterpay_clearpay")]
        public ConfirmationTokenPaymentMethodPreviewAfterpayClearpay AfterpayClearpay { get; set; }

        [JsonProperty("alipay")]
        [STJS.JsonPropertyName("alipay")]
        public ConfirmationTokenPaymentMethodPreviewAlipay Alipay { get; set; }

        /// <summary>
        /// This field indicates whether this payment method can be shown again to its customer in a
        /// checkout flow. Stripe products such as Checkout and Elements use this field to determine
        /// whether a payment method can be shown as a saved payment method in a checkout flow. The
        /// field defaults to “unspecified”.
        /// One of: <c>always</c>, <c>limited</c>, or <c>unspecified</c>.
        /// </summary>
        [JsonProperty("allow_redisplay")]
        [STJS.JsonPropertyName("allow_redisplay")]
        public string AllowRedisplay { get; set; }

        [JsonProperty("alma")]
        [STJS.JsonPropertyName("alma")]
        public ConfirmationTokenPaymentMethodPreviewAlma Alma { get; set; }

        [JsonProperty("amazon_pay")]
        [STJS.JsonPropertyName("amazon_pay")]
        public ConfirmationTokenPaymentMethodPreviewAmazonPay AmazonPay { get; set; }

        [JsonProperty("au_becs_debit")]
        [STJS.JsonPropertyName("au_becs_debit")]
        public ConfirmationTokenPaymentMethodPreviewAuBecsDebit AuBecsDebit { get; set; }

        [JsonProperty("bacs_debit")]
        [STJS.JsonPropertyName("bacs_debit")]
        public ConfirmationTokenPaymentMethodPreviewBacsDebit BacsDebit { get; set; }

        [JsonProperty("bancontact")]
        [STJS.JsonPropertyName("bancontact")]
        public ConfirmationTokenPaymentMethodPreviewBancontact Bancontact { get; set; }

        [JsonProperty("billie")]
        [STJS.JsonPropertyName("billie")]
        public ConfirmationTokenPaymentMethodPreviewBillie Billie { get; set; }

        [JsonProperty("billing_details")]
        [STJS.JsonPropertyName("billing_details")]
        public ConfirmationTokenPaymentMethodPreviewBillingDetails BillingDetails { get; set; }

        [JsonProperty("blik")]
        [STJS.JsonPropertyName("blik")]
        public ConfirmationTokenPaymentMethodPreviewBlik Blik { get; set; }

        [JsonProperty("boleto")]
        [STJS.JsonPropertyName("boleto")]
        public ConfirmationTokenPaymentMethodPreviewBoleto Boleto { get; set; }

        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public ConfirmationTokenPaymentMethodPreviewCard Card { get; set; }

        [JsonProperty("card_present")]
        [STJS.JsonPropertyName("card_present")]
        public ConfirmationTokenPaymentMethodPreviewCardPresent CardPresent { get; set; }

        [JsonProperty("cashapp")]
        [STJS.JsonPropertyName("cashapp")]
        public ConfirmationTokenPaymentMethodPreviewCashapp Cashapp { get; set; }

        [JsonProperty("crypto")]
        [STJS.JsonPropertyName("crypto")]
        public ConfirmationTokenPaymentMethodPreviewCrypto Crypto { get; set; }

        #region Expandable Customer

        /// <summary>
        /// (ID of the Customer)
        /// The ID of the Customer to which this PaymentMethod is saved. This will not be set when
        /// the PaymentMethod has not been saved to a Customer.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string CustomerId
        {
            get => this.InternalCustomer?.Id;
            set => this.InternalCustomer = SetExpandableFieldId(value, this.InternalCustomer);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the Customer to which this PaymentMethod is saved. This will not be set when
        /// the PaymentMethod has not been saved to a Customer.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public Customer Customer
        {
            get => this.InternalCustomer?.ExpandedObject;
            set => this.InternalCustomer = SetExpandableFieldObject(value, this.InternalCustomer);
        }

        [JsonProperty("customer")]
        [JsonConverter(typeof(ExpandableFieldConverter<Customer>))]
        [STJS.JsonPropertyName("customer")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Customer>))]
        internal ExpandableField<Customer> InternalCustomer { get; set; }
        #endregion

        [JsonProperty("customer_account")]
        [STJS.JsonPropertyName("customer_account")]
        public string CustomerAccount { get; set; }

        [JsonProperty("customer_balance")]
        [STJS.JsonPropertyName("customer_balance")]
        public ConfirmationTokenPaymentMethodPreviewCustomerBalance CustomerBalance { get; set; }

        [JsonProperty("eps")]
        [STJS.JsonPropertyName("eps")]
        public ConfirmationTokenPaymentMethodPreviewEps Eps { get; set; }

        [JsonProperty("fpx")]
        [STJS.JsonPropertyName("fpx")]
        public ConfirmationTokenPaymentMethodPreviewFpx Fpx { get; set; }

        [JsonProperty("giropay")]
        [STJS.JsonPropertyName("giropay")]
        public ConfirmationTokenPaymentMethodPreviewGiropay Giropay { get; set; }

        [JsonProperty("gopay")]
        [STJS.JsonPropertyName("gopay")]
        public ConfirmationTokenPaymentMethodPreviewGopay Gopay { get; set; }

        [JsonProperty("grabpay")]
        [STJS.JsonPropertyName("grabpay")]
        public ConfirmationTokenPaymentMethodPreviewGrabpay Grabpay { get; set; }

        [JsonProperty("id_bank_transfer")]
        [STJS.JsonPropertyName("id_bank_transfer")]
        public ConfirmationTokenPaymentMethodPreviewIdBankTransfer IdBankTransfer { get; set; }

        [JsonProperty("ideal")]
        [STJS.JsonPropertyName("ideal")]
        public ConfirmationTokenPaymentMethodPreviewIdeal Ideal { get; set; }

        [JsonProperty("interac_present")]
        [STJS.JsonPropertyName("interac_present")]
        public ConfirmationTokenPaymentMethodPreviewInteracPresent InteracPresent { get; set; }

        [JsonProperty("kakao_pay")]
        [STJS.JsonPropertyName("kakao_pay")]
        public ConfirmationTokenPaymentMethodPreviewKakaoPay KakaoPay { get; set; }

        [JsonProperty("klarna")]
        [STJS.JsonPropertyName("klarna")]
        public ConfirmationTokenPaymentMethodPreviewKlarna Klarna { get; set; }

        [JsonProperty("konbini")]
        [STJS.JsonPropertyName("konbini")]
        public ConfirmationTokenPaymentMethodPreviewKonbini Konbini { get; set; }

        [JsonProperty("kr_card")]
        [STJS.JsonPropertyName("kr_card")]
        public ConfirmationTokenPaymentMethodPreviewKrCard KrCard { get; set; }

        [JsonProperty("link")]
        [STJS.JsonPropertyName("link")]
        public ConfirmationTokenPaymentMethodPreviewLink Link { get; set; }

        [JsonProperty("mb_way")]
        [STJS.JsonPropertyName("mb_way")]
        public ConfirmationTokenPaymentMethodPreviewMbWay MbWay { get; set; }

        [JsonProperty("mobilepay")]
        [STJS.JsonPropertyName("mobilepay")]
        public ConfirmationTokenPaymentMethodPreviewMobilepay Mobilepay { get; set; }

        [JsonProperty("multibanco")]
        [STJS.JsonPropertyName("multibanco")]
        public ConfirmationTokenPaymentMethodPreviewMultibanco Multibanco { get; set; }

        [JsonProperty("naver_pay")]
        [STJS.JsonPropertyName("naver_pay")]
        public ConfirmationTokenPaymentMethodPreviewNaverPay NaverPay { get; set; }

        [JsonProperty("nz_bank_account")]
        [STJS.JsonPropertyName("nz_bank_account")]
        public ConfirmationTokenPaymentMethodPreviewNzBankAccount NzBankAccount { get; set; }

        [JsonProperty("oxxo")]
        [STJS.JsonPropertyName("oxxo")]
        public ConfirmationTokenPaymentMethodPreviewOxxo Oxxo { get; set; }

        [JsonProperty("p24")]
        [STJS.JsonPropertyName("p24")]
        public ConfirmationTokenPaymentMethodPreviewP24 P24 { get; set; }

        [JsonProperty("pay_by_bank")]
        [STJS.JsonPropertyName("pay_by_bank")]
        public ConfirmationTokenPaymentMethodPreviewPayByBank PayByBank { get; set; }

        [JsonProperty("payco")]
        [STJS.JsonPropertyName("payco")]
        public ConfirmationTokenPaymentMethodPreviewPayco Payco { get; set; }

        [JsonProperty("paynow")]
        [STJS.JsonPropertyName("paynow")]
        public ConfirmationTokenPaymentMethodPreviewPaynow Paynow { get; set; }

        [JsonProperty("paypal")]
        [STJS.JsonPropertyName("paypal")]
        public ConfirmationTokenPaymentMethodPreviewPaypal Paypal { get; set; }

        [JsonProperty("paypay")]
        [STJS.JsonPropertyName("paypay")]
        public ConfirmationTokenPaymentMethodPreviewPaypay Paypay { get; set; }

        [JsonProperty("payto")]
        [STJS.JsonPropertyName("payto")]
        public ConfirmationTokenPaymentMethodPreviewPayto Payto { get; set; }

        [JsonProperty("pix")]
        [STJS.JsonPropertyName("pix")]
        public ConfirmationTokenPaymentMethodPreviewPix Pix { get; set; }

        [JsonProperty("promptpay")]
        [STJS.JsonPropertyName("promptpay")]
        public ConfirmationTokenPaymentMethodPreviewPromptpay Promptpay { get; set; }

        [JsonProperty("qris")]
        [STJS.JsonPropertyName("qris")]
        public ConfirmationTokenPaymentMethodPreviewQris Qris { get; set; }

        [JsonProperty("rechnung")]
        [STJS.JsonPropertyName("rechnung")]
        public ConfirmationTokenPaymentMethodPreviewRechnung Rechnung { get; set; }

        [JsonProperty("revolut_pay")]
        [STJS.JsonPropertyName("revolut_pay")]
        public ConfirmationTokenPaymentMethodPreviewRevolutPay RevolutPay { get; set; }

        [JsonProperty("samsung_pay")]
        [STJS.JsonPropertyName("samsung_pay")]
        public ConfirmationTokenPaymentMethodPreviewSamsungPay SamsungPay { get; set; }

        [JsonProperty("satispay")]
        [STJS.JsonPropertyName("satispay")]
        public ConfirmationTokenPaymentMethodPreviewSatispay Satispay { get; set; }

        [JsonProperty("sepa_debit")]
        [STJS.JsonPropertyName("sepa_debit")]
        public ConfirmationTokenPaymentMethodPreviewSepaDebit SepaDebit { get; set; }

        [JsonProperty("shopeepay")]
        [STJS.JsonPropertyName("shopeepay")]
        public ConfirmationTokenPaymentMethodPreviewShopeepay Shopeepay { get; set; }

        [JsonProperty("sofort")]
        [STJS.JsonPropertyName("sofort")]
        public ConfirmationTokenPaymentMethodPreviewSofort Sofort { get; set; }

        [JsonProperty("stripe_balance")]
        [STJS.JsonPropertyName("stripe_balance")]
        public ConfirmationTokenPaymentMethodPreviewStripeBalance StripeBalance { get; set; }

        [JsonProperty("sunbit")]
        [STJS.JsonPropertyName("sunbit")]
        public ConfirmationTokenPaymentMethodPreviewSunbit Sunbit { get; set; }

        [JsonProperty("swish")]
        [STJS.JsonPropertyName("swish")]
        public ConfirmationTokenPaymentMethodPreviewSwish Swish { get; set; }

        [JsonProperty("twint")]
        [STJS.JsonPropertyName("twint")]
        public ConfirmationTokenPaymentMethodPreviewTwint Twint { get; set; }

        /// <summary>
        /// The type of the PaymentMethod. An additional hash is included on the PaymentMethod with
        /// a name matching this value. It contains additional information specific to the
        /// PaymentMethod type.
        /// One of: <c>acss_debit</c>, <c>affirm</c>, <c>afterpay_clearpay</c>, <c>alipay</c>,
        /// <c>alma</c>, <c>amazon_pay</c>, <c>au_becs_debit</c>, <c>bacs_debit</c>,
        /// <c>bancontact</c>, <c>billie</c>, <c>blik</c>, <c>boleto</c>, <c>card</c>,
        /// <c>card_present</c>, <c>cashapp</c>, <c>crypto</c>, <c>custom</c>,
        /// <c>customer_balance</c>, <c>eps</c>, <c>fpx</c>, <c>giropay</c>, <c>gopay</c>,
        /// <c>grabpay</c>, <c>id_bank_transfer</c>, <c>ideal</c>, <c>interac_present</c>,
        /// <c>kakao_pay</c>, <c>klarna</c>, <c>konbini</c>, <c>kr_card</c>, <c>link</c>,
        /// <c>mb_way</c>, <c>mobilepay</c>, <c>multibanco</c>, <c>naver_pay</c>,
        /// <c>nz_bank_account</c>, <c>oxxo</c>, <c>p24</c>, <c>pay_by_bank</c>, <c>payco</c>,
        /// <c>paynow</c>, <c>paypal</c>, <c>paypay</c>, <c>payto</c>, <c>pix</c>, <c>promptpay</c>,
        /// <c>qris</c>, <c>rechnung</c>, <c>revolut_pay</c>, <c>samsung_pay</c>, <c>satispay</c>,
        /// <c>sepa_debit</c>, <c>shopeepay</c>, <c>sofort</c>, <c>stripe_balance</c>,
        /// <c>sunbit</c>, <c>swish</c>, <c>twint</c>, <c>upi</c>, <c>us_bank_account</c>,
        /// <c>wechat_pay</c>, or <c>zip</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonProperty("upi")]
        [STJS.JsonPropertyName("upi")]
        public ConfirmationTokenPaymentMethodPreviewUpi Upi { get; set; }

        [JsonProperty("us_bank_account")]
        [STJS.JsonPropertyName("us_bank_account")]
        public ConfirmationTokenPaymentMethodPreviewUsBankAccount UsBankAccount { get; set; }

        [JsonProperty("wechat_pay")]
        [STJS.JsonPropertyName("wechat_pay")]
        public ConfirmationTokenPaymentMethodPreviewWechatPay WechatPay { get; set; }

        [JsonProperty("zip")]
        [STJS.JsonPropertyName("zip")]
        public ConfirmationTokenPaymentMethodPreviewZip Zip { get; set; }
    }
}
