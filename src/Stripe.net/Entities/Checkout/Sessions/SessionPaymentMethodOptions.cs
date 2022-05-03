// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionPaymentMethodOptions : StripeEntity<SessionPaymentMethodOptions>
    {
        [JsonProperty("acss_debit")]
        public SessionPaymentMethodOptionsAcssDebit AcssDebit { get; set; }

        [JsonProperty("alipay")]
        public SessionPaymentMethodOptionsAlipay Alipay { get; set; }

        [JsonProperty("boleto")]
        public SessionPaymentMethodOptionsBoleto Boleto { get; set; }

        [JsonProperty("konbini")]
        public SessionPaymentMethodOptionsKonbini Konbini { get; set; }

        [JsonProperty("oxxo")]
        public SessionPaymentMethodOptionsOxxo Oxxo { get; set; }

        [JsonProperty("us_bank_account")]
        public SessionPaymentMethodOptionsUsBankAccount UsBankAccount { get; set; }
    }
}
