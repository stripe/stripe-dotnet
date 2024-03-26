// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptions : StripeEntity<PaymentIntentPaymentMethodOptions>
    {
        [JsonProperty("acss_debit")]
        public PaymentIntentPaymentMethodOptionsAcssDebit AcssDebit { get; set; }

        [JsonProperty("affirm")]
        public PaymentIntentPaymentMethodOptionsAffirm Affirm { get; set; }

        [JsonProperty("afterpay_clearpay")]
        public PaymentIntentPaymentMethodOptionsAfterpayClearpay AfterpayClearpay { get; set; }

        [JsonProperty("alipay")]
        public PaymentIntentPaymentMethodOptionsAlipay Alipay { get; set; }

        [JsonProperty("au_becs_debit")]
        public PaymentIntentPaymentMethodOptionsAuBecsDebit AuBecsDebit { get; set; }

        [JsonProperty("bacs_debit")]
        public PaymentIntentPaymentMethodOptionsBacsDebit BacsDebit { get; set; }

        [JsonProperty("bancontact")]
        public PaymentIntentPaymentMethodOptionsBancontact Bancontact { get; set; }

        [JsonProperty("blik")]
        public PaymentIntentPaymentMethodOptionsBlik Blik { get; set; }

        [JsonProperty("boleto")]
        public PaymentIntentPaymentMethodOptionsBoleto Boleto { get; set; }

        [JsonProperty("card")]
        public PaymentIntentPaymentMethodOptionsCard Card { get; set; }

        [JsonProperty("card_present")]
        public PaymentIntentPaymentMethodOptionsCardPresent CardPresent { get; set; }

        [JsonProperty("cashapp")]
        public PaymentIntentPaymentMethodOptionsCashapp Cashapp { get; set; }

        [JsonProperty("customer_balance")]
        public PaymentIntentPaymentMethodOptionsCustomerBalance CustomerBalance { get; set; }

        [JsonProperty("eps")]
        public PaymentIntentPaymentMethodOptionsEps Eps { get; set; }

        [JsonProperty("fpx")]
        public PaymentIntentPaymentMethodOptionsFpx Fpx { get; set; }

        [JsonProperty("giropay")]
        public PaymentIntentPaymentMethodOptionsGiropay Giropay { get; set; }

        [JsonProperty("grabpay")]
        public PaymentIntentPaymentMethodOptionsGrabpay Grabpay { get; set; }

        [JsonProperty("ideal")]
        public PaymentIntentPaymentMethodOptionsIdeal Ideal { get; set; }

        [JsonProperty("interac_present")]
        public PaymentIntentPaymentMethodOptionsInteracPresent InteracPresent { get; set; }

        [JsonProperty("klarna")]
        public PaymentIntentPaymentMethodOptionsKlarna Klarna { get; set; }

        [JsonProperty("konbini")]
        public PaymentIntentPaymentMethodOptionsKonbini Konbini { get; set; }

        [JsonProperty("link")]
        public PaymentIntentPaymentMethodOptionsLink Link { get; set; }

        [JsonProperty("mobilepay")]
        public PaymentIntentPaymentMethodOptionsMobilepay Mobilepay { get; set; }

        [JsonProperty("oxxo")]
        public PaymentIntentPaymentMethodOptionsOxxo Oxxo { get; set; }

        [JsonProperty("p24")]
        public PaymentIntentPaymentMethodOptionsP24 P24 { get; set; }

        [JsonProperty("paynow")]
        public PaymentIntentPaymentMethodOptionsPaynow Paynow { get; set; }

        [JsonProperty("paypal")]
        public PaymentIntentPaymentMethodOptionsPaypal Paypal { get; set; }

        [JsonProperty("pix")]
        public PaymentIntentPaymentMethodOptionsPix Pix { get; set; }

        [JsonProperty("promptpay")]
        public PaymentIntentPaymentMethodOptionsPromptpay Promptpay { get; set; }

        [JsonProperty("revolut_pay")]
        public PaymentIntentPaymentMethodOptionsRevolutPay RevolutPay { get; set; }

        [JsonProperty("sepa_debit")]
        public PaymentIntentPaymentMethodOptionsSepaDebit SepaDebit { get; set; }

        [JsonProperty("sofort")]
        public PaymentIntentPaymentMethodOptionsSofort Sofort { get; set; }

        [JsonProperty("swish")]
        public PaymentIntentPaymentMethodOptionsSwish Swish { get; set; }

        [JsonProperty("us_bank_account")]
        public PaymentIntentPaymentMethodOptionsUsBankAccount UsBankAccount { get; set; }

        [JsonProperty("wechat_pay")]
        public PaymentIntentPaymentMethodOptionsWechatPay WechatPay { get; set; }

        [JsonProperty("zip")]
        public PaymentIntentPaymentMethodOptionsZip Zip { get; set; }
    }
}
