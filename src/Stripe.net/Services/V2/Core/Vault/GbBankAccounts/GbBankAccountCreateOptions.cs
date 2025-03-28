// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Vault
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class GbBankAccountCreateOptions : BaseOptions
    {
        /// <summary>
        /// The Account Number of the bank account.
        /// </summary>
        [JsonProperty("account_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_number")]
#endif
        public string AccountNumber { get; set; }

        /// <summary>
        /// Closed Enum. The type of the bank account (checking or savings).
        /// One of: <c>checking</c>, or <c>savings</c>.
        /// </summary>
        [JsonProperty("bank_account_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_account_type")]
#endif
        public string BankAccountType { get; set; }

        /// <summary>
        /// Whether or not to automatically perform Confirmation of Payee to verify the users
        /// information against what was provided by the bank. Doing so is required for all bank
        /// accounts not owned by you before making domestic UK OutboundPayments.
        /// </summary>
        [JsonProperty("confirmation_of_payee")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("confirmation_of_payee")]
#endif
        public GbBankAccountCreateConfirmationOfPayeeOptions ConfirmationOfPayee { get; set; }

        /// <summary>
        /// The Sort Code of the bank account.
        /// </summary>
        [JsonProperty("sort_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sort_code")]
#endif
        public string SortCode { get; set; }
    }
}
