// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CustomerCashBalanceTransactionFunded : StripeEntity<CustomerCashBalanceTransactionFunded>
    {
        [JsonProperty("bank_transfer")]
        [STJS.JsonPropertyName("bank_transfer")]
        public CustomerCashBalanceTransactionFundedBankTransfer BankTransfer { get; set; }
    }
}
