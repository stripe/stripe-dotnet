namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ChargePaymentMethodDetailsBitcoin : StripeEntity<ChargePaymentMethodDetailsBitcoin>
    {
        [JsonProperty("address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address")]
#endif
        public string Address { get; set; }

        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long? Amount { get; set; }

        [JsonProperty("amount_charged")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_charged")]
#endif
        public long? AmountCharged { get; set; }

        [JsonProperty("amount_received")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_received")]
#endif
        public long? AmountReceived { get; set; }

        [JsonProperty("amount_returned")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_returned")]
#endif
        public long? AmountReturned { get; set; }

        [JsonProperty("refund_address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("refund_address")]
#endif
        public string RefundAddress { get; set; }
    }
}
