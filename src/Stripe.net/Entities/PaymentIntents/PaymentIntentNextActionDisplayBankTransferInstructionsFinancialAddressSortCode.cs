// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressSortCode : StripeEntity<PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressSortCode>
    {
        [JsonProperty("account_holder_address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_holder_address")]
#endif
        public Address AccountHolderAddress { get; set; }

        /// <summary>
        /// The name of the person or business that owns the bank account.
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

        [JsonProperty("bank_address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_address")]
#endif
        public Address BankAddress { get; set; }

        /// <summary>
        /// The six-digit sort code.
        /// </summary>
        [JsonProperty("sort_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sort_code")]
#endif
        public string SortCode { get; set; }
    }
}
