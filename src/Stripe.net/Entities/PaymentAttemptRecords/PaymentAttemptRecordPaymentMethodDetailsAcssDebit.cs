// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentAttemptRecordPaymentMethodDetailsAcssDebit : StripeEntity<PaymentAttemptRecordPaymentMethodDetailsAcssDebit>
    {
        /// <summary>
        /// Name of the bank associated with the bank account.
        /// </summary>
        [JsonProperty("bank_name")]
        [STJS.JsonPropertyName("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// Estimated date to debit the customer's bank account. A date string in YYYY-MM-DD format.
        /// </summary>
        [JsonProperty("expected_debit_date")]
        [STJS.JsonPropertyName("expected_debit_date")]
        public string ExpectedDebitDate { get; set; }

        /// <summary>
        /// Uniquely identifies this particular bank account. You can use this attribute to check
        /// whether two bank accounts are the same.
        /// </summary>
        [JsonProperty("fingerprint")]
        [STJS.JsonPropertyName("fingerprint")]
        public string Fingerprint { get; set; }

        /// <summary>
        /// Institution number of the bank account.
        /// </summary>
        [JsonProperty("institution_number")]
        [STJS.JsonPropertyName("institution_number")]
        public string InstitutionNumber { get; set; }

        /// <summary>
        /// Last four digits of the bank account number.
        /// </summary>
        [JsonProperty("last4")]
        [STJS.JsonPropertyName("last4")]
        public string Last4 { get; set; }

        /// <summary>
        /// ID of the mandate used to make this payment.
        /// </summary>
        [JsonProperty("mandate")]
        [STJS.JsonPropertyName("mandate")]
        public string Mandate { get; set; }

        /// <summary>
        /// Transit number of the bank account.
        /// </summary>
        [JsonProperty("transit_number")]
        [STJS.JsonPropertyName("transit_number")]
        public string TransitNumber { get; set; }
    }
}
