// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CustomerCashBalanceTransactionFundedBankTransferUsBankTransfer : StripeEntity<CustomerCashBalanceTransactionFundedBankTransferUsBankTransfer>
    {
        /// <summary>
        /// The banking network used for this funding.
        /// One of: <c>ach</c>, <c>domestic_wire_us</c>, or <c>swift</c>.
        /// </summary>
        [JsonProperty("network")]
        [STJS.JsonPropertyName("network")]
        public string Network { get; set; }

        /// <summary>
        /// The full name of the sender, as supplied by the sending bank.
        /// </summary>
        [JsonProperty("sender_name")]
        [STJS.JsonPropertyName("sender_name")]
        public string SenderName { get; set; }
    }
}
