// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

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

        [JsonProperty("customer_balance")]
        public ConfirmationTokenPaymentMethodPreviewCustomerBalance CustomerBalance { get; set; }

        [JsonProperty("eps")]
        public ConfirmationTokenPaymentMethodPreviewEps Eps { get; set; }

        [JsonProperty("fpx")]
        public ConfirmationTokenPaymentMethodPreviewFpx Fpx { get; set; }

        [JsonProperty("giropay")]
        public ConfirmationTokenPaymentMethodPreviewGiropay Giropay { get; set; }

        [JsonProperty("grabpay")]
        public ConfirmationTokenPaymentMethodPreviewGrabpay Grabpay { get; set; }

        [JsonProperty("ideal")]
        public ConfirmationTokenPaymentMethodPreviewIdeal Ideal { get; set; }

        [JsonProperty("interac_present")]
        public ConfirmationTokenPaymentMethodPreviewInteracPresent InteracPresent { get; set; }

        [JsonProperty("klarna")]
        public ConfirmationTokenPaymentMethodPreviewKlarna Klarna { get; set; }

        [JsonProperty("konbini")]
        public ConfirmationTokenPaymentMethodPreviewKonbini Konbini { get; set; }

        [JsonProperty("link")]
        public ConfirmationTokenPaymentMethodPreviewLink Link { get; set; }

        [JsonProperty("mobilepay")]
        public ConfirmationTokenPaymentMethodPreviewMobilepay Mobilepay { get; set; }

        [JsonProperty("oxxo")]
        public ConfirmationTokenPaymentMethodPreviewOxxo Oxxo { get; set; }

        [JsonProperty("p24")]
        public ConfirmationTokenPaymentMethodPreviewP24 P24 { get; set; }

        [JsonProperty("paynow")]
        public ConfirmationTokenPaymentMethodPreviewPaynow Paynow { get; set; }

        [JsonProperty("paypal")]
        public ConfirmationTokenPaymentMethodPreviewPaypal Paypal { get; set; }

        [JsonProperty("pix")]
        public ConfirmationTokenPaymentMethodPreviewPix Pix { get; set; }

        [JsonProperty("promptpay")]
        public ConfirmationTokenPaymentMethodPreviewPromptpay Promptpay { get; set; }

        [JsonProperty("revolut_pay")]
        public ConfirmationTokenPaymentMethodPreviewRevolutPay RevolutPay { get; set; }

        [JsonProperty("sepa_debit")]
        public ConfirmationTokenPaymentMethodPreviewSepaDebit SepaDebit { get; set; }

        [JsonProperty("sofort")]
        public ConfirmationTokenPaymentMethodPreviewSofort Sofort { get; set; }

        [JsonProperty("swish")]
        public ConfirmationTokenPaymentMethodPreviewSwish Swish { get; set; }

        /// <summary>
        /// The type of the PaymentMethod. An additional hash is included on the PaymentMethod with
        /// a name matching this value. It contains additional information specific to the
        /// PaymentMethod type.
        /// One of: <c>acss_debit</c>, <c>affirm</c>, <c>afterpay_clearpay</c>, <c>alipay</c>,
        /// <c>au_becs_debit</c>, <c>bacs_debit</c>, <c>bancontact</c>, <c>blik</c>, <c>boleto</c>,
        /// <c>card</c>, <c>card_present</c>, <c>cashapp</c>, <c>customer_balance</c>, <c>eps</c>,
        /// <c>fpx</c>, <c>giropay</c>, <c>grabpay</c>, <c>ideal</c>, <c>interac_present</c>,
        /// <c>klarna</c>, <c>konbini</c>, <c>link</c>, <c>mobilepay</c>, <c>oxxo</c>, <c>p24</c>,
        /// <c>paynow</c>, <c>paypal</c>, <c>pix</c>, <c>promptpay</c>, <c>revolut_pay</c>,
        /// <c>sepa_debit</c>, <c>sofort</c>, <c>swish</c>, <c>us_bank_account</c>,
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
