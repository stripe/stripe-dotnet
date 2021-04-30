// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupAttemptPaymentMethodDetails : StripeEntity<SetupAttemptPaymentMethodDetails>
    {
        [JsonProperty("acss_debit")]
        public SetupAttemptPaymentMethodDetailsAcssDebit AcssDebit { get; set; }

        [JsonProperty("au_becs_debit")]
        public SetupAttemptPaymentMethodDetailsAuBecsDebit AuBecsDebit { get; set; }

        [JsonProperty("bacs_debit")]
        public SetupAttemptPaymentMethodDetailsBacsDebit BacsDebit { get; set; }

        [JsonProperty("bancontact")]
        public SetupAttemptPaymentMethodDetailsBancontact Bancontact { get; set; }

        [JsonProperty("card")]
        public SetupAttemptPaymentMethodDetailsCard Card { get; set; }

        [JsonProperty("card_present")]
        public SetupAttemptPaymentMethodDetailsCardPresent CardPresent { get; set; }

        [JsonProperty("ideal")]
        public SetupAttemptPaymentMethodDetailsIdeal Ideal { get; set; }

        [JsonProperty("sepa_debit")]
        public SetupAttemptPaymentMethodDetailsSepaDebit SepaDebit { get; set; }

        [JsonProperty("sofort")]
        public SetupAttemptPaymentMethodDetailsSofort Sofort { get; set; }

        /// <summary>
        /// The type of the payment method used in the SetupIntent (e.g., <c>card</c>). An
        /// additional hash is included on <c>payment_method_details</c> with a name matching this
        /// value. It contains confirmation-specific information for the payment method.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
