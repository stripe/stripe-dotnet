// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SourceReceiver : StripeEntity<SourceReceiver>
    {
        /// <summary>
        /// The address of the receiver source. This is the value that should be communicated to the
        /// customer to send their funds to.
        /// </summary>
        [JsonProperty("address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address")]
#endif

        public string Address { get; set; }

        /// <summary>
        /// The total amount that was moved to your balance. This is almost always equal to the
        /// amount charged. In rare cases when customers deposit excess funds and we are unable to
        /// refund those, those funds get moved to your balance and show up in amount_charged as
        /// well. The amount charged is expressed in the source's currency.
        /// </summary>
        [JsonProperty("amount_charged")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_charged")]
#endif

        public long AmountCharged { get; set; }

        /// <summary>
        /// The total amount received by the receiver source. <c>amount_received = amount_returned +
        /// amount_charged</c> should be true for consumed sources unless customers deposit excess
        /// funds. The amount received is expressed in the source's currency.
        /// </summary>
        [JsonProperty("amount_received")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_received")]
#endif

        public long AmountReceived { get; set; }

        /// <summary>
        /// The total amount that was returned to the customer. The amount returned is expressed in
        /// the source's currency.
        /// </summary>
        [JsonProperty("amount_returned")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_returned")]
#endif

        public long AmountReturned { get; set; }

        /// <summary>
        /// Type of refund attribute method, one of <c>email</c>, <c>manual</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("refund_attributes_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("refund_attributes_method")]
#endif

        public string RefundAttributesMethod { get; set; }

        /// <summary>
        /// Type of refund attribute status, one of <c>missing</c>, <c>requested</c>, or
        /// <c>available</c>.
        /// </summary>
        [JsonProperty("refund_attributes_status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("refund_attributes_status")]
#endif

        public string RefundAttributesStatus { get; set; }
    }
}
