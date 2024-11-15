// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CustomerCashBalanceTransactionFundedBankTransfer : StripeEntity<CustomerCashBalanceTransactionFundedBankTransfer>
    {
        [JsonProperty("eu_bank_transfer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("eu_bank_transfer")]
#endif

        public CustomerCashBalanceTransactionFundedBankTransferEuBankTransfer EuBankTransfer { get; set; }

        [JsonProperty("gb_bank_transfer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("gb_bank_transfer")]
#endif

        public CustomerCashBalanceTransactionFundedBankTransferGbBankTransfer GbBankTransfer { get; set; }

        [JsonProperty("jp_bank_transfer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("jp_bank_transfer")]
#endif

        public CustomerCashBalanceTransactionFundedBankTransferJpBankTransfer JpBankTransfer { get; set; }

        /// <summary>
        /// The user-supplied reference field on the bank transfer.
        /// </summary>
        [JsonProperty("reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reference")]
#endif

        public string Reference { get; set; }

        /// <summary>
        /// The funding method type used to fund the customer balance. Permitted values include:
        /// <c>eu_bank_transfer</c>, <c>gb_bank_transfer</c>, <c>jp_bank_transfer</c>,
        /// <c>mx_bank_transfer</c>, or <c>us_bank_transfer</c>.
        /// One of: <c>eu_bank_transfer</c>, <c>gb_bank_transfer</c>, <c>jp_bank_transfer</c>,
        /// <c>mx_bank_transfer</c>, or <c>us_bank_transfer</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif

        public string Type { get; set; }

        [JsonProperty("us_bank_transfer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("us_bank_transfer")]
#endif

        public CustomerCashBalanceTransactionFundedBankTransferUsBankTransfer UsBankTransfer { get; set; }
    }
}
