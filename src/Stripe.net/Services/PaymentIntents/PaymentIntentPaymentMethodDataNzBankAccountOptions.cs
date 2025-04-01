// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentMethodDataNzBankAccountOptions : INestedOptions
    {
        /// <summary>
        /// The name on the bank account. Only required if the account holder name is different from
        /// the name of the authorized signatory collected in the PaymentMethod’s billing details.
        /// </summary>
        [JsonProperty("account_holder_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_holder_name")]
#endif
        public string AccountHolderName { get; set; }

        /// <summary>
        /// The account number for the bank account.
        /// </summary>
        [JsonProperty("account_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_number")]
#endif
        public string AccountNumber { get; set; }

        /// <summary>
        /// The numeric code for the bank account's bank.
        /// </summary>
        [JsonProperty("bank_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_code")]
#endif
        public string BankCode { get; set; }

        /// <summary>
        /// The numeric code for the bank account's bank branch.
        /// </summary>
        [JsonProperty("branch_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("branch_code")]
#endif
        public string BranchCode { get; set; }

        [JsonProperty("reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reference")]
#endif
        public string Reference { get; set; }

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
