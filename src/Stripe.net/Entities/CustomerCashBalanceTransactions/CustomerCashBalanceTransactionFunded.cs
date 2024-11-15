// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CustomerCashBalanceTransactionFunded : StripeEntity<CustomerCashBalanceTransactionFunded>
    {
        [JsonProperty("bank_transfer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_transfer")]
#endif

        public CustomerCashBalanceTransactionFundedBankTransfer BankTransfer { get; set; }
    }
}
