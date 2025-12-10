// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentRecordPaymentMethodDetailsNzBankAccount : StripeEntity<PaymentRecordPaymentMethodDetailsNzBankAccount>
    {
        /// <summary>
        /// The name on the bank account. Only present if the account holder name is different from
        /// the name of the authorized signatory collected in the PaymentMethod’s billing details.
        /// </summary>
        [JsonProperty("account_holder_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_holder_name")]
#endif
        public string AccountHolderName { get; set; }

        /// <summary>
        /// The numeric code for the bank account's bank.
        /// </summary>
        [JsonProperty("bank_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_code")]
#endif
        public string BankCode { get; set; }

        /// <summary>
        /// The name of the bank.
        /// </summary>
        [JsonProperty("bank_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_name")]
#endif
        public string BankName { get; set; }

        /// <summary>
        /// The numeric code for the bank account's bank branch.
        /// </summary>
        [JsonProperty("branch_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("branch_code")]
#endif
        public string BranchCode { get; set; }

        /// <summary>
        /// Estimated date to debit the customer's bank account. A date string in YYYY-MM-DD format.
        /// </summary>
        [JsonProperty("expected_debit_date")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expected_debit_date")]
#endif
        public string ExpectedDebitDate { get; set; }

        /// <summary>
        /// Last four digits of the bank account number.
        /// </summary>
        [JsonProperty("last4")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("last4")]
#endif
        public string Last4 { get; set; }

        /// <summary>
        /// The suffix of the bank account number.
        /// </summary>
        [JsonProperty("suffix")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("suffix")]
#endif
        public string Suffix { get; set; }
    }
}
