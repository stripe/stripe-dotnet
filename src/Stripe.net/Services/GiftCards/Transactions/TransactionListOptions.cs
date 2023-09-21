// File generated from our OpenAPI spec
namespace Stripe.GiftCards
{
    using Newtonsoft.Json;

    public class TransactionListOptions : ListOptions
    {
        /// <summary>
        /// The gift card to list transactions for.
        /// </summary>
        [JsonProperty("gift_card")]
        public string GiftCard { get; set; }

        /// <summary>
        /// A string that identifies this transaction as part of a group. See the <a
        /// href="https://stripe.com/docs/connect/separate-charges-and-transfers">Connect
        /// documentation</a> for details.
        /// </summary>
        [JsonProperty("transfer_group")]
        public string TransferGroup { get; set; }
    }
}
