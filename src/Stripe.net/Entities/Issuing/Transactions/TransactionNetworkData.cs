// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class TransactionNetworkData : StripeEntity<TransactionNetworkData>
    {
        /// <summary>
        /// The date the transaction was processed by the card network. This can be different from
        /// the date the seller recorded the transaction depending on when the acquirer submits the
        /// transaction to the network.
        /// </summary>
        [JsonProperty("processing_date")]
        public string ProcessingDate { get; set; }
    }
}
