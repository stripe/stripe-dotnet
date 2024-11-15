// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RefundDestinationDetails : StripeEntity<RefundDestinationDetails>
    {
        [JsonProperty("affirm")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("affirm")]
#endif

        public RefundDestinationDetailsAffirm Affirm { get; set; }

        [JsonProperty("afterpay_clearpay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("afterpay_clearpay")]
#endif

        public RefundDestinationDetailsAfterpayClearpay AfterpayClearpay { get; set; }

        [JsonProperty("alipay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("alipay")]
#endif

        public RefundDestinationDetailsAlipay Alipay { get; set; }

        [JsonProperty("alma")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("alma")]
#endif

        public RefundDestinationDetailsAlma Alma { get; set; }

        [JsonProperty("amazon_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amazon_pay")]
#endif

        public RefundDestinationDetailsAmazonPay AmazonPay { get; set; }

        [JsonProperty("au_bank_transfer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("au_bank_transfer")]
#endif

        public RefundDestinationDetailsAuBankTransfer AuBankTransfer { get; set; }

        [JsonProperty("blik")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("blik")]
#endif

        public RefundDestinationDetailsBlik Blik { get; set; }

        [JsonProperty("br_bank_transfer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("br_bank_transfer")]
#endif

        public RefundDestinationDetailsBrBankTransfer BrBankTransfer { get; set; }

        [JsonProperty("card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card")]
#endif

        public RefundDestinationDetailsCard Card { get; set; }

        [JsonProperty("cashapp")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cashapp")]
#endif

        public RefundDestinationDetailsCashapp Cashapp { get; set; }

        [JsonProperty("customer_cash_balance")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_cash_balance")]
#endif

        public RefundDestinationDetailsCustomerCashBalance CustomerCashBalance { get; set; }

        [JsonProperty("eps")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("eps")]
#endif

        public RefundDestinationDetailsEps Eps { get; set; }

        [JsonProperty("eu_bank_transfer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("eu_bank_transfer")]
#endif

        public RefundDestinationDetailsEuBankTransfer EuBankTransfer { get; set; }

        [JsonProperty("gb_bank_transfer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("gb_bank_transfer")]
#endif

        public RefundDestinationDetailsGbBankTransfer GbBankTransfer { get; set; }

        [JsonProperty("giropay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("giropay")]
#endif

        public RefundDestinationDetailsGiropay Giropay { get; set; }

        [JsonProperty("grabpay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("grabpay")]
#endif

        public RefundDestinationDetailsGrabpay Grabpay { get; set; }

        [JsonProperty("jp_bank_transfer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("jp_bank_transfer")]
#endif

        public RefundDestinationDetailsJpBankTransfer JpBankTransfer { get; set; }

        [JsonProperty("klarna")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("klarna")]
#endif

        public RefundDestinationDetailsKlarna Klarna { get; set; }

        [JsonProperty("multibanco")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("multibanco")]
#endif

        public RefundDestinationDetailsMultibanco Multibanco { get; set; }

        [JsonProperty("mx_bank_transfer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mx_bank_transfer")]
#endif

        public RefundDestinationDetailsMxBankTransfer MxBankTransfer { get; set; }

        [JsonProperty("p24")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("p24")]
#endif

        public RefundDestinationDetailsP24 P24 { get; set; }

        [JsonProperty("paynow")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paynow")]
#endif

        public RefundDestinationDetailsPaynow Paynow { get; set; }

        [JsonProperty("paypal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paypal")]
#endif

        public RefundDestinationDetailsPaypal Paypal { get; set; }

        [JsonProperty("pix")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pix")]
#endif

        public RefundDestinationDetailsPix Pix { get; set; }

        [JsonProperty("revolut")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("revolut")]
#endif

        public RefundDestinationDetailsRevolut Revolut { get; set; }

        [JsonProperty("sofort")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sofort")]
#endif

        public RefundDestinationDetailsSofort Sofort { get; set; }

        [JsonProperty("swish")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("swish")]
#endif

        public RefundDestinationDetailsSwish Swish { get; set; }

        [JsonProperty("th_bank_transfer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("th_bank_transfer")]
#endif

        public RefundDestinationDetailsThBankTransfer ThBankTransfer { get; set; }

        /// <summary>
        /// The type of transaction-specific details of the payment method used in the refund (e.g.,
        /// <c>card</c>). An additional hash is included on <c>destination_details</c> with a name
        /// matching this value. It contains information specific to the refund transaction.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif

        public string Type { get; set; }

        [JsonProperty("us_bank_transfer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("us_bank_transfer")]
#endif

        public RefundDestinationDetailsUsBankTransfer UsBankTransfer { get; set; }

        [JsonProperty("wechat_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("wechat_pay")]
#endif

        public RefundDestinationDetailsWechatPay WechatPay { get; set; }

        [JsonProperty("zip")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("zip")]
#endif

        public RefundDestinationDetailsZip Zip { get; set; }
    }
}
