// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReceivedDebitBankTransferOriginatingBankAccountAba : StripeEntity<ReceivedDebitBankTransferOriginatingBankAccountAba>
    {
        /// <summary>
        /// The name of the account holder that originated the debit, as provided by the ACH
        /// network.
        /// </summary>
        [JsonProperty("account_holder_name")]
        [STJS.JsonPropertyName("account_holder_name")]
        public string AccountHolderName { get; set; }

        /// <summary>
        /// The name of the bank the debit originated from.
        /// </summary>
        [JsonProperty("bank_name")]
        [STJS.JsonPropertyName("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// The routing number of the bank that originated the debit.
        /// </summary>
        [JsonProperty("routing_number")]
        [STJS.JsonPropertyName("routing_number")]
        public string RoutingNumber { get; set; }
    }
}
