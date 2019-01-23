namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceReceiver : StripeEntity<SourceReceiver>
    {
        /// <summary>
        /// The address of the receiver source. This is the value that should be communicated to the customer to send their funds to.
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// The total amount charged by you. The amount charged is expressed in the source’s currency.
        /// </summary>
        [JsonProperty("amount_charged")]
        public long AmountCharged { get; set; }

        /// <summary>
        /// The total amount received by the receiver source. AmountReceived = AmountReturned + AmountCharged is true at all times. The amount received is expressed in the source’s currency.
        /// </summary>
        [JsonProperty("amount_received")]
        public long AmountReceived { get; set; }

        /// <summary>
        /// The total amount that was returned to the customer. The amount returned is expressed in the source’s currency.
        /// </summary>
        [JsonProperty("amount_returned")]
        public long AmountReturned { get; set; }
    }
}
