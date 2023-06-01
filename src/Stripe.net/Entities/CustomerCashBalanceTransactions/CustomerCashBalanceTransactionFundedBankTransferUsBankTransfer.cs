// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class CustomerCashBalanceTransactionFundedBankTransferUsBankTransfer : StripeEntity<CustomerCashBalanceTransactionFundedBankTransferUsBankTransfer>
    {
        /// <summary>
        /// The banking network used for this funding.
        /// One of: <c>ach</c>, <c>domestic_wire_us</c>, or <c>swift</c>.
        /// </summary>
        [JsonProperty("network")]
        public string Network { get; set; }

        /// <summary>
        /// The full name of the sender, as supplied by the sending bank.
        /// </summary>
        [JsonProperty("sender_name")]
        public string SenderName { get; set; }
    }
}
