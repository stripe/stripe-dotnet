// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAddressCredentialsCaBankAccount : StripeEntity<FinancialAddressCredentialsCaBankAccount>
    {
        /// <summary>
        /// The account holder name to be used during bank transfers.
        /// </summary>
        [JsonProperty("account_holder_name")]
        [STJS.JsonPropertyName("account_holder_name")]
        public string AccountHolderName { get; set; }

        /// <summary>
        /// The account number of the Canadian Bank Account.
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
        /// The institution number of the Canadian Bank Account.
        /// </summary>
        [JsonProperty("institution_number")]
        [STJS.JsonPropertyName("institution_number")]
        public string InstitutionNumber { get; set; }

        /// <summary>
        /// The last four digits of the Canadian Bank Account number. This will always be returned.
        /// To view the full account number when retrieving or listing FinancialAddresses, use the
        /// <c>include</c> request parameter.
        /// </summary>
        [JsonProperty("last4")]
        [STJS.JsonPropertyName("last4")]
        public string Last4 { get; set; }

        /// <summary>
        /// The transit number of the Canadian Bank Account.
        /// </summary>
        [JsonProperty("transit_number")]
        [STJS.JsonPropertyName("transit_number")]
        public string TransitNumber { get; set; }
    }
}
