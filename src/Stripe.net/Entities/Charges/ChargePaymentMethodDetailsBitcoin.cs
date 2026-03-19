namespace Stripe
{
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    public class ChargePaymentMethodDetailsBitcoin : StripeEntity<ChargePaymentMethodDetailsBitcoin>
    {
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long? Amount { get; set; }

        [JsonProperty("amount_charged")]
        [STJS.JsonPropertyName("amount_charged")]
        public long? AmountCharged { get; set; }

        [JsonProperty("amount_received")]
        [STJS.JsonPropertyName("amount_received")]
        public long? AmountReceived { get; set; }

        [JsonProperty("amount_returned")]
        [STJS.JsonPropertyName("amount_returned")]
        public long? AmountReturned { get; set; }

        [JsonProperty("refund_address")]
        [STJS.JsonPropertyName("refund_address")]
        public string RefundAddress { get; set; }
    }
}
