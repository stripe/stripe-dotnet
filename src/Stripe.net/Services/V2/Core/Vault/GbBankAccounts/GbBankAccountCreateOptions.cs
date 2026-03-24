// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Vault
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class GbBankAccountCreateOptions : BaseOptions
    {
        /// <summary>
        /// The Account Number of the bank account.
        /// </summary>
        [JsonProperty("account_number")]
        [STJS.JsonPropertyName("account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Closed Enum. The type of the bank account (checking or savings).
        /// One of: <c>checking</c>, or <c>savings</c>.
        /// </summary>
        [JsonProperty("bank_account_type")]
        [STJS.JsonPropertyName("bank_account_type")]
        public string BankAccountType { get; set; }

        /// <summary>
        /// Whether or not to automatically perform Confirmation of Payee to verify the users
        /// information against what was provided by the bank. Doing so is required for all bank
        /// accounts not owned by you before making domestic UK OutboundPayments.
        /// </summary>
        [JsonProperty("confirmation_of_payee")]
        [STJS.JsonPropertyName("confirmation_of_payee")]
        public GbBankAccountCreateConfirmationOfPayeeOptions ConfirmationOfPayee { get; set; }

        /// <summary>
        /// The currency of the bank account.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The IBAN of the bank account.
        /// </summary>
        [JsonProperty("iban")]
        [STJS.JsonPropertyName("iban")]
        public string Iban { get; set; }

        /// <summary>
        /// The Sort Code of the bank account.
        /// </summary>
        [JsonProperty("sort_code")]
        [STJS.JsonPropertyName("sort_code")]
        public string SortCode { get; set; }
    }
}
