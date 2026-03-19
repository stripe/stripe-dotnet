// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RefundDestinationDetails : StripeEntity<RefundDestinationDetails>
    {
        [JsonProperty("affirm")]
        [STJS.JsonPropertyName("affirm")]
        public RefundDestinationDetailsAffirm Affirm { get; set; }

        [JsonProperty("afterpay_clearpay")]
        [STJS.JsonPropertyName("afterpay_clearpay")]
        public RefundDestinationDetailsAfterpayClearpay AfterpayClearpay { get; set; }

        [JsonProperty("alipay")]
        [STJS.JsonPropertyName("alipay")]
        public RefundDestinationDetailsAlipay Alipay { get; set; }

        [JsonProperty("alma")]
        [STJS.JsonPropertyName("alma")]
        public RefundDestinationDetailsAlma Alma { get; set; }

        [JsonProperty("amazon_pay")]
        [STJS.JsonPropertyName("amazon_pay")]
        public RefundDestinationDetailsAmazonPay AmazonPay { get; set; }

        [JsonProperty("au_bank_transfer")]
        [STJS.JsonPropertyName("au_bank_transfer")]
        public RefundDestinationDetailsAuBankTransfer AuBankTransfer { get; set; }

        [JsonProperty("blik")]
        [STJS.JsonPropertyName("blik")]
        public RefundDestinationDetailsBlik Blik { get; set; }

        [JsonProperty("br_bank_transfer")]
        [STJS.JsonPropertyName("br_bank_transfer")]
        public RefundDestinationDetailsBrBankTransfer BrBankTransfer { get; set; }

        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public RefundDestinationDetailsCard Card { get; set; }

        [JsonProperty("cashapp")]
        [STJS.JsonPropertyName("cashapp")]
        public RefundDestinationDetailsCashapp Cashapp { get; set; }

        [JsonProperty("crypto")]
        [STJS.JsonPropertyName("crypto")]
        public RefundDestinationDetailsCrypto Crypto { get; set; }

        [JsonProperty("customer_cash_balance")]
        [STJS.JsonPropertyName("customer_cash_balance")]
        public RefundDestinationDetailsCustomerCashBalance CustomerCashBalance { get; set; }

        [JsonProperty("eps")]
        [STJS.JsonPropertyName("eps")]
        public RefundDestinationDetailsEps Eps { get; set; }

        [JsonProperty("eu_bank_transfer")]
        [STJS.JsonPropertyName("eu_bank_transfer")]
        public RefundDestinationDetailsEuBankTransfer EuBankTransfer { get; set; }

        [JsonProperty("gb_bank_transfer")]
        [STJS.JsonPropertyName("gb_bank_transfer")]
        public RefundDestinationDetailsGbBankTransfer GbBankTransfer { get; set; }

        [JsonProperty("giropay")]
        [STJS.JsonPropertyName("giropay")]
        public RefundDestinationDetailsGiropay Giropay { get; set; }

        [JsonProperty("grabpay")]
        [STJS.JsonPropertyName("grabpay")]
        public RefundDestinationDetailsGrabpay Grabpay { get; set; }

        [JsonProperty("jp_bank_transfer")]
        [STJS.JsonPropertyName("jp_bank_transfer")]
        public RefundDestinationDetailsJpBankTransfer JpBankTransfer { get; set; }

        [JsonProperty("klarna")]
        [STJS.JsonPropertyName("klarna")]
        public RefundDestinationDetailsKlarna Klarna { get; set; }

        [JsonProperty("mb_way")]
        [STJS.JsonPropertyName("mb_way")]
        public RefundDestinationDetailsMbWay MbWay { get; set; }

        [JsonProperty("multibanco")]
        [STJS.JsonPropertyName("multibanco")]
        public RefundDestinationDetailsMultibanco Multibanco { get; set; }

        [JsonProperty("mx_bank_transfer")]
        [STJS.JsonPropertyName("mx_bank_transfer")]
        public RefundDestinationDetailsMxBankTransfer MxBankTransfer { get; set; }

        [JsonProperty("nz_bank_transfer")]
        [STJS.JsonPropertyName("nz_bank_transfer")]
        public RefundDestinationDetailsNzBankTransfer NzBankTransfer { get; set; }

        [JsonProperty("p24")]
        [STJS.JsonPropertyName("p24")]
        public RefundDestinationDetailsP24 P24 { get; set; }

        [JsonProperty("paynow")]
        [STJS.JsonPropertyName("paynow")]
        public RefundDestinationDetailsPaynow Paynow { get; set; }

        [JsonProperty("paypal")]
        [STJS.JsonPropertyName("paypal")]
        public RefundDestinationDetailsPaypal Paypal { get; set; }

        [JsonProperty("pix")]
        [STJS.JsonPropertyName("pix")]
        public RefundDestinationDetailsPix Pix { get; set; }

        [JsonProperty("revolut")]
        [STJS.JsonPropertyName("revolut")]
        public RefundDestinationDetailsRevolut Revolut { get; set; }

        [JsonProperty("sofort")]
        [STJS.JsonPropertyName("sofort")]
        public RefundDestinationDetailsSofort Sofort { get; set; }

        [JsonProperty("swish")]
        [STJS.JsonPropertyName("swish")]
        public RefundDestinationDetailsSwish Swish { get; set; }

        [JsonProperty("th_bank_transfer")]
        [STJS.JsonPropertyName("th_bank_transfer")]
        public RefundDestinationDetailsThBankTransfer ThBankTransfer { get; set; }

        [JsonProperty("twint")]
        [STJS.JsonPropertyName("twint")]
        public RefundDestinationDetailsTwint Twint { get; set; }

        /// <summary>
        /// The type of transaction-specific details of the payment method used in the refund (e.g.,
        /// <c>card</c>). An additional hash is included on <c>destination_details</c> with a name
        /// matching this value. It contains information specific to the refund transaction.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonProperty("us_bank_transfer")]
        [STJS.JsonPropertyName("us_bank_transfer")]
        public RefundDestinationDetailsUsBankTransfer UsBankTransfer { get; set; }

        [JsonProperty("wechat_pay")]
        [STJS.JsonPropertyName("wechat_pay")]
        public RefundDestinationDetailsWechatPay WechatPay { get; set; }

        [JsonProperty("zip")]
        [STJS.JsonPropertyName("zip")]
        public RefundDestinationDetailsZip Zip { get; set; }
    }
}
