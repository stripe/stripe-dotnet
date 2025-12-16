// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentAttemptRecordPaymentMethodDetailsSepaDebit : StripeEntity<PaymentAttemptRecordPaymentMethodDetailsSepaDebit>
    {
        /// <summary>
        /// Bank code of bank associated with the bank account.
        /// </summary>
        [JsonProperty("bank_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_code")]
#endif
        public string BankCode { get; set; }

        /// <summary>
        /// Branch code of bank associated with the bank account.
        /// </summary>
        [JsonProperty("branch_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("branch_code")]
#endif
        public string BranchCode { get; set; }

        /// <summary>
        /// Two-letter ISO code representing the country the bank account is located in.
        /// </summary>
        [JsonProperty("country")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("country")]
#endif
        public string Country { get; set; }

        /// <summary>
        /// Estimated date to debit the customer's bank account. A date string in YYYY-MM-DD format.
        /// </summary>
        [JsonProperty("expected_debit_date")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expected_debit_date")]
#endif
        public string ExpectedDebitDate { get; set; }

        /// <summary>
        /// Uniquely identifies this particular bank account. You can use this attribute to check
        /// whether two bank accounts are the same.
        /// </summary>
        [JsonProperty("fingerprint")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fingerprint")]
#endif
        public string Fingerprint { get; set; }

        /// <summary>
        /// Last four characters of the IBAN.
        /// </summary>
        [JsonProperty("last4")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("last4")]
#endif
        public string Last4 { get; set; }

        /// <summary>
        /// Find the ID of the mandate used for this payment under the <a
        /// href="https://docs.stripe.com/api/charges/object#charge_object-payment_method_details-sepa_debit-mandate">payment_method_details.sepa_debit.mandate</a>
        /// property on the Charge. Use this mandate ID to <a
        /// href="https://docs.stripe.com/api/mandates/retrieve">retrieve the Mandate</a>.
        /// </summary>
        [JsonProperty("mandate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mandate")]
#endif
        public string Mandate { get; set; }
    }
}
