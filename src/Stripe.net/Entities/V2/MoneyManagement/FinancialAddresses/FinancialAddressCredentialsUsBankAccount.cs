// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAddressCredentialsUsBankAccount : StripeEntity<FinancialAddressCredentialsUsBankAccount>
    {
        /// <summary>
        /// The address of the account holder.
        /// </summary>
        [JsonProperty("account_holder_address")]
        [STJS.JsonPropertyName("account_holder_address")]
        public FinancialAddressCredentialsUsBankAccountAccountHolderAddress AccountHolderAddress { get; set; }

        /// <summary>
        /// The name of the account holder.
        /// </summary>
        [JsonProperty("account_holder_name")]
        [STJS.JsonPropertyName("account_holder_name")]
        public string AccountHolderName { get; set; }

        /// <summary>
        /// The account number of the US Bank Account.
        /// </summary>
        [JsonProperty("account_number")]
        [STJS.JsonPropertyName("account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// The name of the Bank.
        /// </summary>
        [JsonProperty("bank_name")]
        [STJS.JsonPropertyName("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// The last four digits of the US Bank Account number. This will always be returned. To
        /// view the full account number when retrieving or listing FinancialAddresses, use the
        /// <c>include</c> request parameter.
        /// </summary>
        [JsonProperty("last4")]
        [STJS.JsonPropertyName("last4")]
        public string Last4 { get; set; }

        /// <summary>
        /// The routing number of the US Bank Account.
        /// </summary>
        [JsonProperty("routing_number")]
        [STJS.JsonPropertyName("routing_number")]
        public string RoutingNumber { get; set; }

        /// <summary>
        /// The swift code of the bank or financial institution.
        /// </summary>
        [JsonProperty("swift_code")]
        [STJS.JsonPropertyName("swift_code")]
        public string SwiftCode { get; set; }
    }
}
