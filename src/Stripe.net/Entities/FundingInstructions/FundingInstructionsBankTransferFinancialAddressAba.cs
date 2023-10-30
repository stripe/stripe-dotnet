// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class FundingInstructionsBankTransferFinancialAddressAba : StripeEntity<FundingInstructionsBankTransferFinancialAddressAba>
    {
        /// <summary>
        /// The ABA account number.
        /// </summary>
        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

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
