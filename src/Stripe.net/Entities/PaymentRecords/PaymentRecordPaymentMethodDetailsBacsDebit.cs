// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentRecordPaymentMethodDetailsBacsDebit : StripeEntity<PaymentRecordPaymentMethodDetailsBacsDebit>
    {
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
        /// Last four digits of the bank account number.
        /// </summary>
        [JsonProperty("last4")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("last4")]
#endif
        public string Last4 { get; set; }

        /// <summary>
        /// ID of the mandate used to make this payment.
        /// </summary>
        [JsonProperty("mandate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mandate")]
#endif
        public string Mandate { get; set; }

        /// <summary>
        /// Sort code of the bank account. (e.g., <c>10-20-30</c>).
        /// </summary>
        [JsonProperty("sort_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sort_code")]
#endif
        public string SortCode { get; set; }
    }
}
