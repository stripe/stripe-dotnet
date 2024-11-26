// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfirmationTokenPaymentMethodPreview : StripeEntity<ConfirmationTokenPaymentMethodPreview>
    {
        [JsonProperty("acss_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("acss_debit")]
#endif
        public ConfirmationTokenPaymentMethodPreviewAcssDebit AcssDebit { get; set; }

        [JsonProperty("affirm")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("affirm")]
#endif
        public ConfirmationTokenPaymentMethodPreviewAffirm Affirm { get; set; }

        [JsonProperty("afterpay_clearpay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("afterpay_clearpay")]
#endif
        public ConfirmationTokenPaymentMethodPreviewAfterpayClearpay AfterpayClearpay { get; set; }

        [JsonProperty("alipay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("alipay")]
#endif
        public ConfirmationTokenPaymentMethodPreviewAlipay Alipay { get; set; }

        /// <summary>
        /// This field indicates whether this payment method can be shown again to its customer in a
        /// checkout flow. Stripe products such as Checkout and Elements use this field to determine
        /// whether a payment method can be shown as a saved payment method in a checkout flow. The
        /// field defaults to “unspecified”.
        /// One of: <c>always</c>, <c>limited</c>, or <c>unspecified</c>.
        /// </summary>
        [JsonProperty("allow_redisplay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("allow_redisplay")]
#endif
        public string AllowRedisplay { get; set; }

        [JsonProperty("alma")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("alma")]
#endif
        public ConfirmationTokenPaymentMethodPreviewAlma Alma { get; set; }

        [JsonProperty("amazon_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amazon_pay")]
#endif
        public ConfirmationTokenPaymentMethodPreviewAmazonPay AmazonPay { get; set; }

        [JsonProperty("au_becs_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("au_becs_debit")]
#endif
        public ConfirmationTokenPaymentMethodPreviewAuBecsDebit AuBecsDebit { get; set; }

        [JsonProperty("bacs_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bacs_debit")]
#endif
        public ConfirmationTokenPaymentMethodPreviewBacsDebit BacsDebit { get; set; }

        [JsonProperty("bancontact")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bancontact")]
#endif
        public ConfirmationTokenPaymentMethodPreviewBancontact Bancontact { get; set; }

        [JsonProperty("billing_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_details")]
#endif
        public ConfirmationTokenPaymentMethodPreviewBillingDetails BillingDetails { get; set; }

        [JsonProperty("blik")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("blik")]
#endif
        public ConfirmationTokenPaymentMethodPreviewBlik Blik { get; set; }

        [JsonProperty("boleto")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("boleto")]
#endif
        public ConfirmationTokenPaymentMethodPreviewBoleto Boleto { get; set; }

        [JsonProperty("card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card")]
#endif
        public ConfirmationTokenPaymentMethodPreviewCard Card { get; set; }

        [JsonProperty("card_present")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card_present")]
#endif
        public ConfirmationTokenPaymentMethodPreviewCardPresent CardPresent { get; set; }

        [JsonProperty("cashapp")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cashapp")]
#endif
        public ConfirmationTokenPaymentMethodPreviewCashapp Cashapp { get; set; }

        #region Expandable Customer

        /// <summary>
        /// (ID of the Customer)
        /// The ID of the Customer to which this PaymentMethod is saved. This will not be set when
        /// the PaymentMethod has not been saved to a Customer.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
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
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Customer Customer
        {
            get => this.InternalCustomer?.ExpandedObject;
            set => this.InternalCustomer = SetExpandableFieldObject(value, this.InternalCustomer);
        }

        [JsonProperty("customer")]
        [JsonConverter(typeof(ExpandableFieldConverter<Customer>))]
#if NET6_0_OR_GREATER
        [STJS.JsonInclude]
        [STJS.JsonPropertyName("customer")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Customer>))]
#endif
        internal ExpandableField<Customer> InternalCustomer { get; set; }
        #endregion

        [JsonProperty("customer_balance")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_balance")]
#endif
        public ConfirmationTokenPaymentMethodPreviewCustomerBalance CustomerBalance { get; set; }

        [JsonProperty("eps")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("eps")]
#endif
        public ConfirmationTokenPaymentMethodPreviewEps Eps { get; set; }

        [JsonProperty("fpx")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fpx")]
#endif
        public ConfirmationTokenPaymentMethodPreviewFpx Fpx { get; set; }

        [JsonProperty("giropay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("giropay")]
#endif
        public ConfirmationTokenPaymentMethodPreviewGiropay Giropay { get; set; }

        [JsonProperty("grabpay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("grabpay")]
#endif
        public ConfirmationTokenPaymentMethodPreviewGrabpay Grabpay { get; set; }

        [JsonProperty("ideal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ideal")]
#endif
        public ConfirmationTokenPaymentMethodPreviewIdeal Ideal { get; set; }

        [JsonProperty("interac_present")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("interac_present")]
#endif
        public ConfirmationTokenPaymentMethodPreviewInteracPresent InteracPresent { get; set; }

        [JsonProperty("kakao_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("kakao_pay")]
#endif
        public ConfirmationTokenPaymentMethodPreviewKakaoPay KakaoPay { get; set; }

        [JsonProperty("klarna")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("klarna")]
#endif
        public ConfirmationTokenPaymentMethodPreviewKlarna Klarna { get; set; }

        [JsonProperty("konbini")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("konbini")]
#endif
        public ConfirmationTokenPaymentMethodPreviewKonbini Konbini { get; set; }

        [JsonProperty("kr_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("kr_card")]
#endif
        public ConfirmationTokenPaymentMethodPreviewKrCard KrCard { get; set; }

        [JsonProperty("link")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("link")]
#endif
        public ConfirmationTokenPaymentMethodPreviewLink Link { get; set; }

        [JsonProperty("mobilepay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mobilepay")]
#endif
        public ConfirmationTokenPaymentMethodPreviewMobilepay Mobilepay { get; set; }

        [JsonProperty("multibanco")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("multibanco")]
#endif
        public ConfirmationTokenPaymentMethodPreviewMultibanco Multibanco { get; set; }

        [JsonProperty("naver_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("naver_pay")]
#endif
        public ConfirmationTokenPaymentMethodPreviewNaverPay NaverPay { get; set; }

        [JsonProperty("oxxo")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("oxxo")]
#endif
        public ConfirmationTokenPaymentMethodPreviewOxxo Oxxo { get; set; }

        [JsonProperty("p24")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("p24")]
#endif
        public ConfirmationTokenPaymentMethodPreviewP24 P24 { get; set; }

        [JsonProperty("payco")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payco")]
#endif
        public ConfirmationTokenPaymentMethodPreviewPayco Payco { get; set; }

        [JsonProperty("paynow")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paynow")]
#endif
        public ConfirmationTokenPaymentMethodPreviewPaynow Paynow { get; set; }

        [JsonProperty("paypal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paypal")]
#endif
        public ConfirmationTokenPaymentMethodPreviewPaypal Paypal { get; set; }

        [JsonProperty("pix")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pix")]
#endif
        public ConfirmationTokenPaymentMethodPreviewPix Pix { get; set; }

        [JsonProperty("promptpay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("promptpay")]
#endif
        public ConfirmationTokenPaymentMethodPreviewPromptpay Promptpay { get; set; }

        [JsonProperty("revolut_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("revolut_pay")]
#endif
        public ConfirmationTokenPaymentMethodPreviewRevolutPay RevolutPay { get; set; }

        [JsonProperty("samsung_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("samsung_pay")]
#endif
        public ConfirmationTokenPaymentMethodPreviewSamsungPay SamsungPay { get; set; }

        [JsonProperty("sepa_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sepa_debit")]
#endif
        public ConfirmationTokenPaymentMethodPreviewSepaDebit SepaDebit { get; set; }

        [JsonProperty("sofort")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sofort")]
#endif
        public ConfirmationTokenPaymentMethodPreviewSofort Sofort { get; set; }

        [JsonProperty("swish")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("swish")]
#endif
        public ConfirmationTokenPaymentMethodPreviewSwish Swish { get; set; }

        [JsonProperty("twint")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("twint")]
#endif
        public ConfirmationTokenPaymentMethodPreviewTwint Twint { get; set; }

        /// <summary>
        /// The type of the PaymentMethod. An additional hash is included on the PaymentMethod with
        /// a name matching this value. It contains additional information specific to the
        /// PaymentMethod type.
        /// One of: <c>acss_debit</c>, <c>affirm</c>, <c>afterpay_clearpay</c>, <c>alipay</c>,
        /// <c>alma</c>, <c>amazon_pay</c>, <c>au_becs_debit</c>, <c>bacs_debit</c>,
        /// <c>bancontact</c>, <c>blik</c>, <c>boleto</c>, <c>card</c>, <c>card_present</c>,
        /// <c>cashapp</c>, <c>customer_balance</c>, <c>eps</c>, <c>fpx</c>, <c>giropay</c>,
        /// <c>grabpay</c>, <c>ideal</c>, <c>interac_present</c>, <c>kakao_pay</c>, <c>klarna</c>,
        /// <c>konbini</c>, <c>kr_card</c>, <c>link</c>, <c>mobilepay</c>, <c>multibanco</c>,
        /// <c>naver_pay</c>, <c>oxxo</c>, <c>p24</c>, <c>payco</c>, <c>paynow</c>, <c>paypal</c>,
        /// <c>pix</c>, <c>promptpay</c>, <c>revolut_pay</c>, <c>samsung_pay</c>, <c>sepa_debit</c>,
        /// <c>sofort</c>, <c>swish</c>, <c>twint</c>, <c>us_bank_account</c>, <c>wechat_pay</c>, or
        /// <c>zip</c>.
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
        public ConfirmationTokenPaymentMethodPreviewUsBankAccount UsBankAccount { get; set; }

        [JsonProperty("wechat_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("wechat_pay")]
#endif
        public ConfirmationTokenPaymentMethodPreviewWechatPay WechatPay { get; set; }

        [JsonProperty("zip")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("zip")]
#endif
        public ConfirmationTokenPaymentMethodPreviewZip Zip { get; set; }
    }
}
