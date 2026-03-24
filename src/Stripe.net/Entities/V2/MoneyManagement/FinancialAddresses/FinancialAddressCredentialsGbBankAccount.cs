// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAddressCredentialsGbBankAccount : StripeEntity<FinancialAddressCredentialsGbBankAccount>
    {
        /// <summary>
        /// The account holder name to be used during bank transference.
        /// </summary>
        [JsonProperty("account_holder_name")]
        [STJS.JsonPropertyName("account_holder_name")]
        public string AccountHolderName { get; set; }

        /// <summary>
        /// The account number of the UK Bank Account.
        /// </summary>
        [JsonProperty("account_number")]
        [STJS.JsonPropertyName("account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// The last four digits of the UK Bank Account number. This will always be returned. To
        /// view the full account number when retrieving or listing FinancialAddresses, use the
        /// <c>include</c> request parameter.
        /// </summary>
        [JsonProperty("last4")]
        [STJS.JsonPropertyName("last4")]
        public string Last4 { get; set; }

        /// <summary>
        /// The sort code of the UK Bank Account.
        /// </summary>
        [JsonProperty("sort_code")]
        [STJS.JsonPropertyName("sort_code")]
        public string SortCode { get; set; }
    }
}
