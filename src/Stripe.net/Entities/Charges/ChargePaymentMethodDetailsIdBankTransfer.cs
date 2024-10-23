// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsIdBankTransfer : StripeEntity<ChargePaymentMethodDetailsIdBankTransfer>
    {
        /// <summary>
        /// Account number of the bank account to transfer funds to.
        /// </summary>
        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Bank where the account is located.
        /// One of: <c>bca</c>, <c>bni</c>, <c>bri</c>, <c>cimb</c>, or <c>permata</c>.
        /// </summary>
        [JsonProperty("bank")]
        public string Bank { get; set; }

        /// <summary>
        /// Local bank code of the bank.
        /// </summary>
        [JsonProperty("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// Name of the bank associated with the bank account.
        /// </summary>
        [JsonProperty("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// Merchant name and billing details name, for the customer to check for the correct
        /// merchant when performing the bank transfer.
        /// </summary>
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }
    }
}
