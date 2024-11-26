// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressZengin : StripeEntity<PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressZengin>
    {
        /// <summary>
        /// The account holder name.
        /// </summary>
        [JsonProperty("account_holder_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_holder_name")]
#endif
        public string AccountHolderName { get; set; }

        /// <summary>
        /// The account number.
        /// </summary>
        [JsonProperty("account_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_number")]
#endif
        public string AccountNumber { get; set; }

        /// <summary>
        /// The bank account type. In Japan, this can only be <c>futsu</c> or <c>toza</c>.
        /// </summary>
        [JsonProperty("account_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_type")]
#endif
        public string AccountType { get; set; }

        /// <summary>
        /// The bank code of the account.
        /// </summary>
        [JsonProperty("bank_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_code")]
#endif
        public string BankCode { get; set; }

        /// <summary>
        /// The bank name of the account.
        /// </summary>
        [JsonProperty("bank_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_name")]
#endif
        public string BankName { get; set; }

        /// <summary>
        /// The branch code of the account.
        /// </summary>
        [JsonProperty("branch_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("branch_code")]
#endif
        public string BranchCode { get; set; }

        /// <summary>
        /// The branch name of the account.
        /// </summary>
        [JsonProperty("branch_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("branch_name")]
#endif
        public string BranchName { get; set; }
    }
}
