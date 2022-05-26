// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionPaymentMethodOptions : StripeEntity<SessionPaymentMethodOptions>
    {
        [JsonProperty("acss_debit")]
        public SessionPaymentMethodOptionsAcssDebit AcssDebit { get; set; }

        [JsonProperty("afterpay_clearpay")]
        public SessionPaymentMethodOptionsAfterpayClearpay AfterpayClearpay { get; set; }

        [JsonProperty("alipay")]
        public SessionPaymentMethodOptionsAlipay Alipay { get; set; }

        [JsonProperty("au_becs_debit")]
        public SessionPaymentMethodOptionsAuBecsDebit AuBecsDebit { get; set; }

        [JsonProperty("bacs_debit")]
        public SessionPaymentMethodOptionsBacsDebit BacsDebit { get; set; }

        [JsonProperty("boleto")]
        public SessionPaymentMethodOptionsBoleto Boleto { get; set; }

        [JsonProperty("eps")]
        public SessionPaymentMethodOptionsEps Eps { get; set; }

        [JsonProperty("fpx")]
        public SessionPaymentMethodOptionsFpx Fpx { get; set; }

        [JsonProperty("giropay")]
        public SessionPaymentMethodOptionsGiropay Giropay { get; set; }

        [JsonProperty("grabpay")]
        public SessionPaymentMethodOptionsGrabpay Grabpay { get; set; }

        [JsonProperty("klarna")]
        public SessionPaymentMethodOptionsKlarna Klarna { get; set; }

        [JsonProperty("konbini")]
        public SessionPaymentMethodOptionsKonbini Konbini { get; set; }

        [JsonProperty("oxxo")]
        public SessionPaymentMethodOptionsOxxo Oxxo { get; set; }

        [JsonProperty("paynow")]
        public SessionPaymentMethodOptionsPaynow Paynow { get; set; }

        [JsonProperty("sepa_debit")]
        public SessionPaymentMethodOptionsSepaDebit SepaDebit { get; set; }

        [JsonProperty("us_bank_account")]
        public SessionPaymentMethodOptionsUsBankAccount UsBankAccount { get; set; }
    }
}
