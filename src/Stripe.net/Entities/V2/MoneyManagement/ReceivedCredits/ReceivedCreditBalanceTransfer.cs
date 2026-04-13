// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReceivedCreditBalanceTransfer : StripeEntity<ReceivedCreditBalanceTransfer>
    {
        /// <summary>
        /// The ID of the account that owns the source object originated the ReceivedCredit.
        /// </summary>
        [JsonProperty("from_account")]
        [STJS.JsonPropertyName("from_account")]
        public string FromAccount { get; set; }

        /// <summary>
        /// The ID of the outbound payment object that originated the ReceivedCredit.
        /// </summary>
        [JsonProperty("outbound_payment")]
        [STJS.JsonPropertyName("outbound_payment")]
        public string OutboundPayment { get; set; }

        /// <summary>
        /// The ID of the outbound transfer object that originated the ReceivedCredit.
        /// </summary>
        [JsonProperty("outbound_transfer")]
        [STJS.JsonPropertyName("outbound_transfer")]
        public string OutboundTransfer { get; set; }

        /// <summary>
        /// The ID of the payout object that originated the ReceivedCredit.
        /// </summary>
        [JsonProperty("payout_v1")]
        [STJS.JsonPropertyName("payout_v1")]
        public string PayoutV1 { get; set; }

        /// <summary>
        /// The ID of the v1 transfer object that originated the ReceivedCredit.
        /// </summary>
        [JsonProperty("transfer")]
        [STJS.JsonPropertyName("transfer")]
        public string Transfer { get; set; }

        /// <summary>
        /// Open Enum. The type of Stripe Money Movement that originated the ReceivedCredit.
        /// One of: <c>outbound_payment</c>, <c>outbound_transfer</c>, <c>transfer</c>, or
        /// <c>payout_v1</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
