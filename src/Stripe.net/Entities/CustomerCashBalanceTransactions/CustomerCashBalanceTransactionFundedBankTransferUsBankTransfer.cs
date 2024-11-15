// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CustomerCashBalanceTransactionFundedBankTransferUsBankTransfer : StripeEntity<CustomerCashBalanceTransactionFundedBankTransferUsBankTransfer>
    {
        /// <summary>
        /// The banking network used for this funding.
        /// One of: <c>ach</c>, <c>domestic_wire_us</c>, or <c>swift</c>.
        /// </summary>
        [JsonProperty("network")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("network")]
#endif

        public string Network { get; set; }

        /// <summary>
        /// The full name of the sender, as supplied by the sending bank.
        /// </summary>
        [JsonProperty("sender_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sender_name")]
#endif

        public string SenderName { get; set; }
    }
}
