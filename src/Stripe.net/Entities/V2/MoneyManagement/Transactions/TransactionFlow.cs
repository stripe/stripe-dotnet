// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class TransactionFlow : StripeEntity<TransactionFlow>
    {
        /// <summary>
        /// If applicable, the ID of the Adjustment that created this Transaction.
        /// </summary>
        [JsonProperty("adjustment")]
        [STJS.JsonPropertyName("adjustment")]
        public string Adjustment { get; set; }

        /// <summary>
        /// When available, the ID of the CurrencyConversion that created this Transaction.
        /// </summary>
        [JsonProperty("currency_conversion")]
        [STJS.JsonPropertyName("currency_conversion")]
        public string CurrencyConversion { get; set; }

        /// <summary>
        /// If applicable, the ID of the FeeBatch that created this Transaction.
        /// </summary>
        [JsonProperty("fee_batch")]
        [STJS.JsonPropertyName("fee_batch")]
        public string FeeBatch { get; set; }

        /// <summary>
        /// If applicable, the ID of the InboundTransfer that created this Transaction.
        /// </summary>
        [JsonProperty("inbound_transfer")]
        [STJS.JsonPropertyName("inbound_transfer")]
        public string InboundTransfer { get; set; }

        /// <summary>
        /// If applicable, the ID of the OutboundPayment that created this Transaction.
        /// </summary>
        [JsonProperty("outbound_payment")]
        [STJS.JsonPropertyName("outbound_payment")]
        public string OutboundPayment { get; set; }

        /// <summary>
        /// If applicable, the ID of the OutboundTransfer that created this Transaction.
        /// </summary>
        [JsonProperty("outbound_transfer")]
        [STJS.JsonPropertyName("outbound_transfer")]
        public string OutboundTransfer { get; set; }

        /// <summary>
        /// If applicable, the ID of the ReceivedCredit that created this Transaction.
        /// </summary>
        [JsonProperty("received_credit")]
        [STJS.JsonPropertyName("received_credit")]
        public string ReceivedCredit { get; set; }

        /// <summary>
        /// If applicable, the ID of the ReceivedDebit that created this Transaction.
        /// </summary>
        [JsonProperty("received_debit")]
        [STJS.JsonPropertyName("received_debit")]
        public string ReceivedDebit { get; set; }

        /// <summary>
        /// Open Enum. The type of flow that created the Transaction. When available, the flow's ID
        /// is provided in the corresponding field.
        /// One of: <c>adjustment</c>, <c>currency_conversion</c>, <c>fee_batch</c>,
        /// <c>inbound_transfer</c>, <c>outbound_payment</c>, <c>outbound_transfer</c>,
        /// <c>received_credit</c>, or <c>received_debit</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
