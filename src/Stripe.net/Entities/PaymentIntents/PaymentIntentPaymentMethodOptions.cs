// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptions : StripeEntity<PaymentIntentPaymentMethodOptions>
    {
        [JsonProperty("acss_debit")]
        public PaymentIntentPaymentMethodOptionsAcssDebit AcssDebit { get; set; }

        [JsonProperty("afterpay_clearpay")]
        public PaymentIntentPaymentMethodOptionsAfterpayClearpay AfterpayClearpay { get; set; }

        [JsonProperty("alipay")]
        public PaymentIntentPaymentMethodOptionsAlipay Alipay { get; set; }

        [JsonProperty("bancontact")]
        public PaymentIntentPaymentMethodOptionsBancontact Bancontact { get; set; }

        [JsonProperty("card")]
        public PaymentIntentPaymentMethodOptionsCard Card { get; set; }

        [JsonProperty("card_present")]
        public PaymentIntentPaymentMethodOptionsCardPresent CardPresent { get; set; }

        [JsonProperty("oxxo")]
        public PaymentIntentPaymentMethodOptionsOxxo Oxxo { get; set; }

        [JsonProperty("p24")]
        public PaymentIntentPaymentMethodOptionsP24 P24 { get; set; }

        [JsonProperty("sepa_debit")]
        public PaymentIntentPaymentMethodOptionsSepaDebit SepaDebit { get; set; }

        [JsonProperty("sofort")]
        public PaymentIntentPaymentMethodOptionsSofort Sofort { get; set; }
    }
}
