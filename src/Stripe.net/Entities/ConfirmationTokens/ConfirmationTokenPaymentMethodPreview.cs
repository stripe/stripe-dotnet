// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ConfirmationTokenPaymentMethodPreview : StripeEntity<ConfirmationTokenPaymentMethodPreview>
    {
        [JsonProperty("acss_debit")]
        public ConfirmationTokenPaymentMethodPreviewAcssDebit AcssDebit { get; set; }

        [JsonProperty("affirm")]
        public ConfirmationTokenPaymentMethodPreviewAffirm Affirm { get; set; }

        [JsonProperty("afterpay_clearpay")]
        public ConfirmationTokenPaymentMethodPreviewAfterpayClearpay AfterpayClearpay { get; set; }

        [JsonProperty("alipay")]
        public ConfirmationTokenPaymentMethodPreviewAlipay Alipay { get; set; }

        /// <summary>
        /// This field indicates whether this payment method can be shown again to its customer in a
        /// checkout flow. Stripe products such as Checkout and Elements use this field to determine
        /// whether a payment method can be shown as a saved payment method in a checkout flow. The
        /// field defaults to “unspecified”.
        /// One of: <c>always</c>, <c>limited</c>, or <c>unspecified</c>.
        /// </summary>
        [JsonProperty("allow_redisplay")]
        public string AllowRedisplay { get; set; }

        [JsonProperty("alma")]
        public ConfirmationTokenPaymentMethodPreviewAlma Alma { get; set; }

        [JsonProperty("amazon_pay")]
        public ConfirmationTokenPaymentMethodPreviewAmazonPay AmazonPay { get; set; }

        [JsonProperty("au_becs_debit")]
        public ConfirmationTokenPaymentMethodPreviewAuBecsDebit AuBecsDebit { get; set; }

        [JsonProperty("bacs_debit")]
        public ConfirmationTokenPaymentMethodPreviewBacsDebit BacsDebit { get; set; }

        [JsonProperty("bancontact")]
        public ConfirmationTokenPaymentMethodPreviewBancontact Bancontact { get; set; }

        [JsonProperty("billing_details")]
        public ConfirmationTokenPaymentMethodPreviewBillingDetails BillingDetails { get; set; }

        [JsonProperty("blik")]
        public ConfirmationTokenPaymentMethodPreviewBlik Blik { get; set; }

        [JsonProperty("boleto")]
        public ConfirmationTokenPaymentMethodPreviewBoleto Boleto { get; set; }

        [JsonProperty("card")]
        public ConfirmationTokenPaymentMethodPreviewCard Card { get; set; }

        [JsonProperty("card_present")]
        public ConfirmationTokenPaymentMethodPreviewCardPresent CardPresent { get; set; }

        [JsonProperty("cashapp")]
        public ConfirmationTokenPaymentMethodPreviewCashapp Cashapp { get; set; }

        #region Expandable Customer

        /// <summary>
        /// (ID of the Customer)
        /// The ID of the Customer to which this PaymentMethod is saved. This will not be set when
        /// the PaymentMethod has not been saved to a Customer.
        /// </summary>
        [JsonIgnore]
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
        public Customer Customer
        {
            get => this.InternalCustomer?.ExpandedObject;
            set => this.InternalCustomer = SetExpandableFieldObject(value, this.InternalCustomer);
        }

        [JsonProperty("customer")]
        [JsonConverter(typeof(ExpandableFieldConverter<Customer>))]
        internal ExpandableField<Customer> InternalCustomer { get; set; }
        #endregion

        [JsonProperty("customer_balance")]
        public ConfirmationTokenPaymentMethodPreviewCustomerBalance CustomerBalance { get; set; }

        [JsonProperty("eps")]
        public ConfirmationTokenPaymentMethodPreviewEps Eps { get; set; }

        [JsonProperty("fpx")]
        public ConfirmationTokenPaymentMethodPreviewFpx Fpx { get; set; }

        [JsonProperty("giropay")]
        public ConfirmationTokenPaymentMethodPreviewGiropay Giropay { get; set; }

        [JsonProperty("gopay")]
        public ConfirmationTokenPaymentMethodPreviewGopay Gopay { get; set; }

        [JsonProperty("grabpay")]
        public ConfirmationTokenPaymentMethodPreviewGrabpay Grabpay { get; set; }

        [JsonProperty("ideal")]
        public ConfirmationTokenPaymentMethodPreviewIdeal Ideal { get; set; }

        [JsonProperty("interac_present")]
        public ConfirmationTokenPaymentMethodPreviewInteracPresent InteracPresent { get; set; }

        [JsonProperty("kakao_pay")]
        public ConfirmationTokenPaymentMethodPreviewKakaoPay KakaoPay { get; set; }

        [JsonProperty("klarna")]
        public ConfirmationTokenPaymentMethodPreviewKlarna Klarna { get; set; }

        [JsonProperty("konbini")]
        public ConfirmationTokenPaymentMethodPreviewKonbini Konbini { get; set; }

        [JsonProperty("kr_card")]
        public ConfirmationTokenPaymentMethodPreviewKrCard KrCard { get; set; }

        [JsonProperty("link")]
        public ConfirmationTokenPaymentMethodPreviewLink Link { get; set; }

        [JsonProperty("mb_way")]
        public ConfirmationTokenPaymentMethodPreviewMbWay MbWay { get; set; }

        [JsonProperty("mobilepay")]
        public ConfirmationTokenPaymentMethodPreviewMobilepay Mobilepay { get; set; }

        [JsonProperty("multibanco")]
        public ConfirmationTokenPaymentMethodPreviewMultibanco Multibanco { get; set; }

        [JsonProperty("naver_pay")]
        public ConfirmationTokenPaymentMethodPreviewNaverPay NaverPay { get; set; }

        [JsonProperty("oxxo")]
        public ConfirmationTokenPaymentMethodPreviewOxxo Oxxo { get; set; }

        [JsonProperty("p24")]
        public ConfirmationTokenPaymentMethodPreviewP24 P24 { get; set; }

        [JsonProperty("payco")]
        public ConfirmationTokenPaymentMethodPreviewPayco Payco { get; set; }

        [JsonProperty("paynow")]
        public ConfirmationTokenPaymentMethodPreviewPaynow Paynow { get; set; }

        [JsonProperty("paypal")]
        public ConfirmationTokenPaymentMethodPreviewPaypal Paypal { get; set; }

        [JsonProperty("payto")]
        public ConfirmationTokenPaymentMethodPreviewPayto Payto { get; set; }

        [JsonProperty("pix")]
        public ConfirmationTokenPaymentMethodPreviewPix Pix { get; set; }

        [JsonProperty("promptpay")]
        public ConfirmationTokenPaymentMethodPreviewPromptpay Promptpay { get; set; }

        [JsonProperty("qris")]
        public ConfirmationTokenPaymentMethodPreviewQris Qris { get; set; }

        [JsonProperty("rechnung")]
        public ConfirmationTokenPaymentMethodPreviewRechnung Rechnung { get; set; }

        [JsonProperty("revolut_pay")]
        public ConfirmationTokenPaymentMethodPreviewRevolutPay RevolutPay { get; set; }

        [JsonProperty("samsung_pay")]
        public ConfirmationTokenPaymentMethodPreviewSamsungPay SamsungPay { get; set; }

        [JsonProperty("sepa_debit")]
        public ConfirmationTokenPaymentMethodPreviewSepaDebit SepaDebit { get; set; }

        [JsonProperty("shopeepay")]
        public ConfirmationTokenPaymentMethodPreviewShopeepay Shopeepay { get; set; }

        [JsonProperty("sofort")]
        public ConfirmationTokenPaymentMethodPreviewSofort Sofort { get; set; }

        [JsonProperty("swish")]
        public ConfirmationTokenPaymentMethodPreviewSwish Swish { get; set; }

        [JsonProperty("twint")]
        public ConfirmationTokenPaymentMethodPreviewTwint Twint { get; set; }

        /// <summary>
        /// The type of the PaymentMethod. An additional hash is included on the PaymentMethod with
        /// a name matching this value. It contains additional information specific to the
        /// PaymentMethod type.
        /// One of: <c>acss_debit</c>, <c>affirm</c>, <c>afterpay_clearpay</c>, <c>alipay</c>,
        /// <c>alma</c>, <c>amazon_pay</c>, <c>au_becs_debit</c>, <c>bacs_debit</c>,
        /// <c>bancontact</c>, <c>blik</c>, <c>boleto</c>, <c>card</c>, <c>card_present</c>,
        /// <c>cashapp</c>, <c>customer_balance</c>, <c>eps</c>, <c>fpx</c>, <c>giropay</c>,
        /// <c>gopay</c>, <c>grabpay</c>, <c>ideal</c>, <c>interac_present</c>, <c>kakao_pay</c>,
        /// <c>klarna</c>, <c>konbini</c>, <c>kr_card</c>, <c>link</c>, <c>mb_way</c>,
        /// <c>mobilepay</c>, <c>multibanco</c>, <c>naver_pay</c>, <c>oxxo</c>, <c>p24</c>,
        /// <c>payco</c>, <c>paynow</c>, <c>paypal</c>, <c>payto</c>, <c>pix</c>, <c>promptpay</c>,
        /// <c>qris</c>, <c>rechnung</c>, <c>revolut_pay</c>, <c>samsung_pay</c>, <c>sepa_debit</c>,
        /// <c>shopeepay</c>, <c>sofort</c>, <c>swish</c>, <c>twint</c>, <c>us_bank_account</c>,
        /// <c>wechat_pay</c>, or <c>zip</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("us_bank_account")]
        public ConfirmationTokenPaymentMethodPreviewUsBankAccount UsBankAccount { get; set; }

        [JsonProperty("wechat_pay")]
        public ConfirmationTokenPaymentMethodPreviewWechatPay WechatPay { get; set; }

        [JsonProperty("zip")]
        public ConfirmationTokenPaymentMethodPreviewZip Zip { get; set; }
    }
}
