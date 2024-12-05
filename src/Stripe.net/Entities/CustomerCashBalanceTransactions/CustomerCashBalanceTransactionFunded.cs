// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class CustomerCashBalanceTransactionFunded : StripeEntity<CustomerCashBalanceTransactionFunded>
    {
        [JsonProperty("bank_transfer")]
        public CustomerCashBalanceTransactionFundedBankTransfer BankTransfer { get; set; }
    }
}
