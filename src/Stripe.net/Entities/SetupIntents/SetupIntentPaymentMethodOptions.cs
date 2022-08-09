// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupIntentPaymentMethodOptions : StripeEntity<SetupIntentPaymentMethodOptions>
    {
        [JsonProperty("acss_debit")]
        public SetupIntentPaymentMethodOptionsAcssDebit AcssDebit { get; set; }

        [JsonProperty("blik")]
        public SetupIntentPaymentMethodOptionsBlik Blik { get; set; }

        [JsonProperty("card")]
        public SetupIntentPaymentMethodOptionsCard Card { get; set; }

        [JsonProperty("link")]
        public SetupIntentPaymentMethodOptionsLink Link { get; set; }

        [JsonProperty("sepa_debit")]
        public SetupIntentPaymentMethodOptionsSepaDebit SepaDebit { get; set; }

        [JsonProperty("us_bank_account")]
        public SetupIntentPaymentMethodOptionsUsBankAccount UsBankAccount { get; set; }
    }
}
