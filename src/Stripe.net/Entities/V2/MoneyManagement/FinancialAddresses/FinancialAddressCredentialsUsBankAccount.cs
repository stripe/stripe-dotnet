// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FinancialAddressCredentialsUsBankAccount : StripeEntity<FinancialAddressCredentialsUsBankAccount>
    {
        /// <summary>
        /// The address of the account holder.
        /// </summary>
        [JsonProperty("account_holder_address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_holder_address")]
#endif
        public FinancialAddressCredentialsUsBankAccountAccountHolderAddress AccountHolderAddress { get; set; }

        /// <summary>
        /// The name of the account holder.
        /// </summary>
        [JsonProperty("account_holder_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_holder_name")]
#endif
        public string AccountHolderName { get; set; }

        /// <summary>
        /// The account number of the US Bank Account.
        /// </summary>
        [JsonProperty("account_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_number")]
#endif
        public string AccountNumber { get; set; }

        /// <summary>
        /// The name of the Bank.
        /// </summary>
        [JsonProperty("bank_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_name")]
#endif
        public string BankName { get; set; }

        /// <summary>
        /// The last four digits of the US Bank Account number. This will always be returned. To
        /// view the full account number when retrieving or listing FinancialAddresses, use the
        /// <c>include</c> request parameter.
        /// </summary>
        [JsonProperty("last4")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("last4")]
#endif
        public string Last4 { get; set; }

        /// <summary>
        /// The routing number of the US Bank Account.
        /// </summary>
        [JsonProperty("routing_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("routing_number")]
#endif
        public string RoutingNumber { get; set; }

        /// <summary>
        /// The swift code of the bank or financial institution.
        /// </summary>
        [JsonProperty("swift_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("swift_code")]
#endif
        public string SwiftCode { get; set; }
    }
}
