// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentMethodDataNzBankAccountOptions : INestedOptions
    {
        /// <summary>
        /// The name on the bank account. Only required if the account holder name is different from
        /// the name of the authorized signatory collected in the PaymentMethod’s billing details.
        /// </summary>
        [JsonProperty("account_holder_name")]
        [STJS.JsonPropertyName("account_holder_name")]
        public string AccountHolderName { get; set; }

        /// <summary>
        /// The account number for the bank account.
        /// </summary>
        [JsonProperty("account_number")]
        [STJS.JsonPropertyName("account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// The numeric code for the bank account's bank.
        /// </summary>
        [JsonProperty("bank_code")]
        [STJS.JsonPropertyName("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// The numeric code for the bank account's bank branch.
        /// </summary>
        [JsonProperty("branch_code")]
        [STJS.JsonPropertyName("branch_code")]
        public string BranchCode { get; set; }

        [JsonProperty("reference")]
        [STJS.JsonPropertyName("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// The suffix of the bank account number.
        /// </summary>
        [JsonProperty("suffix")]
        [STJS.JsonPropertyName("suffix")]
        public string Suffix { get; set; }
    }
}
