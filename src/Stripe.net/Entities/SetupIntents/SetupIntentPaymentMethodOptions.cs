// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SetupIntentPaymentMethodOptions : StripeEntity<SetupIntentPaymentMethodOptions>
    {
        [JsonProperty("acss_debit")]
        [STJS.JsonPropertyName("acss_debit")]
        public SetupIntentPaymentMethodOptionsAcssDebit AcssDebit { get; set; }

        [JsonProperty("amazon_pay")]
        [STJS.JsonPropertyName("amazon_pay")]
        public SetupIntentPaymentMethodOptionsAmazonPay AmazonPay { get; set; }

        [JsonProperty("bacs_debit")]
        [STJS.JsonPropertyName("bacs_debit")]
        public SetupIntentPaymentMethodOptionsBacsDebit BacsDebit { get; set; }

        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public SetupIntentPaymentMethodOptionsCard Card { get; set; }

        [JsonProperty("card_present")]
        [STJS.JsonPropertyName("card_present")]
        public SetupIntentPaymentMethodOptionsCardPresent CardPresent { get; set; }

        [JsonProperty("klarna")]
        [STJS.JsonPropertyName("klarna")]
        public SetupIntentPaymentMethodOptionsKlarna Klarna { get; set; }

        [JsonProperty("link")]
        [STJS.JsonPropertyName("link")]
        public SetupIntentPaymentMethodOptionsLink Link { get; set; }

        [JsonProperty("paypal")]
        [STJS.JsonPropertyName("paypal")]
        public SetupIntentPaymentMethodOptionsPaypal Paypal { get; set; }

        [JsonProperty("payto")]
        [STJS.JsonPropertyName("payto")]
        public SetupIntentPaymentMethodOptionsPayto Payto { get; set; }

        [JsonProperty("sepa_debit")]
        [STJS.JsonPropertyName("sepa_debit")]
        public SetupIntentPaymentMethodOptionsSepaDebit SepaDebit { get; set; }

        [JsonProperty("upi")]
        [STJS.JsonPropertyName("upi")]
        public SetupIntentPaymentMethodOptionsUpi Upi { get; set; }

        [JsonProperty("us_bank_account")]
        [STJS.JsonPropertyName("us_bank_account")]
        public SetupIntentPaymentMethodOptionsUsBankAccount UsBankAccount { get; set; }
    }
}
