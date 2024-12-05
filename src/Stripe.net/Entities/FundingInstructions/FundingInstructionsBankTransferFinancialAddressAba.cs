// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class FundingInstructionsBankTransferFinancialAddressAba : StripeEntity<FundingInstructionsBankTransferFinancialAddressAba>
    {
        [JsonProperty("account_holder_address")]
        public Address AccountHolderAddress { get; set; }

        /// <summary>
        /// The account holder name.
        /// </summary>
        [JsonProperty("account_holder_name")]
        public string AccountHolderName { get; set; }

        /// <summary>
        /// The ABA account number.
        /// </summary>
        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// The account type.
        /// </summary>
        [JsonProperty("account_type")]
        public string AccountType { get; set; }

        [JsonProperty("bank_address")]
        public Address BankAddress { get; set; }

        /// <summary>
        /// The bank name.
        /// </summary>
        [JsonProperty("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// The ABA routing number.
        /// </summary>
        [JsonProperty("routing_number")]
        public string RoutingNumber { get; set; }
    }
}
