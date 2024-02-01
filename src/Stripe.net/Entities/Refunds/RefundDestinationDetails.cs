// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class RefundDestinationDetails : StripeEntity<RefundDestinationDetails>
    {
        [JsonProperty("affirm")]
        public RefundDestinationDetailsAffirm Affirm { get; set; }

        [JsonProperty("afterpay_clearpay")]
        public RefundDestinationDetailsAfterpayClearpay AfterpayClearpay { get; set; }

        [JsonProperty("alipay")]
        public RefundDestinationDetailsAlipay Alipay { get; set; }

        [JsonProperty("au_bank_transfer")]
        public RefundDestinationDetailsAuBankTransfer AuBankTransfer { get; set; }

        [JsonProperty("blik")]
        public RefundDestinationDetailsBlik Blik { get; set; }

        [JsonProperty("br_bank_transfer")]
        public RefundDestinationDetailsBrBankTransfer BrBankTransfer { get; set; }

        [JsonProperty("card")]
        public RefundDestinationDetailsCard Card { get; set; }

        [JsonProperty("cashapp")]
        public RefundDestinationDetailsCashapp Cashapp { get; set; }

        [JsonProperty("customer_cash_balance")]
        public RefundDestinationDetailsCustomerCashBalance CustomerCashBalance { get; set; }

        [JsonProperty("eps")]
        public RefundDestinationDetailsEps Eps { get; set; }

        [JsonProperty("eu_bank_transfer")]
        public RefundDestinationDetailsEuBankTransfer EuBankTransfer { get; set; }

        [JsonProperty("gb_bank_transfer")]
        public RefundDestinationDetailsGbBankTransfer GbBankTransfer { get; set; }

        [JsonProperty("giropay")]
        public RefundDestinationDetailsGiropay Giropay { get; set; }

        [JsonProperty("grabpay")]
        public RefundDestinationDetailsGrabpay Grabpay { get; set; }

        [JsonProperty("jp_bank_transfer")]
        public RefundDestinationDetailsJpBankTransfer JpBankTransfer { get; set; }

        [JsonProperty("klarna")]
        public RefundDestinationDetailsKlarna Klarna { get; set; }

        [JsonProperty("mx_bank_transfer")]
        public RefundDestinationDetailsMxBankTransfer MxBankTransfer { get; set; }

        [JsonProperty("p24")]
        public RefundDestinationDetailsP24 P24 { get; set; }

        [JsonProperty("paynow")]
        public RefundDestinationDetailsPaynow Paynow { get; set; }

        [JsonProperty("paypal")]
        public RefundDestinationDetailsPaypal Paypal { get; set; }

        [JsonProperty("pix")]
        public RefundDestinationDetailsPix Pix { get; set; }

        [JsonProperty("revolut")]
        public RefundDestinationDetailsRevolut Revolut { get; set; }

        [JsonProperty("sofort")]
        public RefundDestinationDetailsSofort Sofort { get; set; }

        [JsonProperty("swish")]
        public RefundDestinationDetailsSwish Swish { get; set; }

        [JsonProperty("th_bank_transfer")]
        public RefundDestinationDetailsThBankTransfer ThBankTransfer { get; set; }

        /// <summary>
        /// The type of transaction-specific details of the payment method used in the refund (e.g.,
        /// <c>card</c>). An additional hash is included on <c>destination_details</c> with a name
        /// matching this value. It contains information specific to the refund transaction.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("us_bank_transfer")]
        public RefundDestinationDetailsUsBankTransfer UsBankTransfer { get; set; }

        [JsonProperty("wechat_pay")]
        public RefundDestinationDetailsWechatPay WechatPay { get; set; }

        [JsonProperty("zip")]
        public RefundDestinationDetailsZip Zip { get; set; }
    }
}
