// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentRecordPaymentMethodDetailsNzBankAccount : StripeEntity<PaymentRecordPaymentMethodDetailsNzBankAccount>
    {
        /// <summary>
        /// The name on the bank account. Only present if the account holder name is different from
        /// the name of the authorized signatory collected in the PaymentMethod’s billing details.
        /// </summary>
        [JsonProperty("account_holder_name")]
        [STJS.JsonPropertyName("account_holder_name")]
        public string AccountHolderName { get; set; }

        /// <summary>
        /// The numeric code for the bank account's bank.
        /// </summary>
        [JsonProperty("bank_code")]
        [STJS.JsonPropertyName("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// The name of the bank.
        /// </summary>
        [JsonProperty("bank_name")]
        [STJS.JsonPropertyName("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// The numeric code for the bank account's bank branch.
        /// </summary>
        [JsonProperty("branch_code")]
        [STJS.JsonPropertyName("branch_code")]
        public string BranchCode { get; set; }

        /// <summary>
        /// Estimated date to debit the customer's bank account. A date string in YYYY-MM-DD format.
        /// </summary>
        [JsonProperty("expected_debit_date")]
        [STJS.JsonPropertyName("expected_debit_date")]
        public string ExpectedDebitDate { get; set; }

        /// <summary>
        /// Last four digits of the bank account number.
        /// </summary>
        [JsonProperty("last4")]
        [STJS.JsonPropertyName("last4")]
        public string Last4 { get; set; }

        /// <summary>
        /// The suffix of the bank account number.
        /// </summary>
        [JsonProperty("suffix")]
        [STJS.JsonPropertyName("suffix")]
        public string Suffix { get; set; }
    }
}
