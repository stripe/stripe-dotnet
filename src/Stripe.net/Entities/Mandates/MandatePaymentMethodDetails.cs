// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class MandatePaymentMethodDetails : StripeEntity<MandatePaymentMethodDetails>
    {
        [JsonProperty("acss_debit")]
        public MandatePaymentMethodDetailsAcssDebit AcssDebit { get; set; }

        [JsonProperty("au_becs_debit")]
        public MandatePaymentMethodDetailsAuBecsDebit AuBecsDebit { get; set; }

        [JsonProperty("bacs_debit")]
        public MandatePaymentMethodDetailsBacsDebit BacsDebit { get; set; }

        [JsonProperty("card")]
        public MandatePaymentMethodDetailsCard Card { get; set; }

        [JsonProperty("cashapp")]
        public MandatePaymentMethodDetailsCashapp Cashapp { get; set; }

        [JsonProperty("link")]
        public MandatePaymentMethodDetailsLink Link { get; set; }

        [JsonProperty("paypal")]
        public MandatePaymentMethodDetailsPaypal Paypal { get; set; }

        [JsonProperty("sepa_debit")]
        public MandatePaymentMethodDetailsSepaDebit SepaDebit { get; set; }

        /// <summary>
        /// This mandate corresponds with a specific payment method type. The
        /// <c>payment_method_details</c> includes an additional hash with the same name and
        /// contains mandate information that's specific to that payment method.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("us_bank_account")]
        public MandatePaymentMethodDetailsUsBankAccount UsBankAccount { get; set; }
    }
}
