namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceReceiver : StripeEntity<SourceReceiver>
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("amount_charged")]
        public long AmountCharged { get; set; }

        [JsonProperty("amount_received")]
        public long AmountReceived { get; set; }

        [JsonProperty("amount_returned")]
        public long AmountReturned { get; set; }

        [JsonProperty("refund_attributes_method")]
        public string RefundAttributesMethod { get; set; }

        [JsonProperty("refund_attributes_status")]
        public string RefundAttributesStatus { get; set; }
    }
}
