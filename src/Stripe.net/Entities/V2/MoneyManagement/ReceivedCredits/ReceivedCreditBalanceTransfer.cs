// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReceivedCreditBalanceTransfer : StripeEntity<ReceivedCreditBalanceTransfer>
    {
        /// <summary>
        /// The ID of the account that owns the source object originated the ReceivedCredit.
        /// </summary>
        [JsonProperty("from_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("from_account")]
#endif
        public string FromAccount { get; set; }

        /// <summary>
        /// Open Enum. The type of Stripe Money Movement that originated the ReceivedCredit.
        /// One of: <c>outbound_payment</c>, <c>outbound_transfer</c>, <c>transfer</c>, or
        /// <c>payout_v1</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// The ID of the outbound payment object that originated the ReceivedCredit.
        /// </summary>
        [JsonProperty("outbound_payment")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("outbound_payment")]
#endif
        public string OutboundPayment { get; set; }

        /// <summary>
        /// The ID of the outbound transfer object that originated the ReceivedCredit.
        /// </summary>
        [JsonProperty("outbound_transfer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("outbound_transfer")]
#endif
        public string OutboundTransfer { get; set; }

        /// <summary>
        /// The ID of the payout object that originated the ReceivedCredit.
        /// </summary>
        [JsonProperty("payout_v1")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payout_v1")]
#endif
        public string PayoutV1 { get; set; }

        /// <summary>
        /// The ID of the v1 transfer object that originated the ReceivedCredit.
        /// </summary>
        [JsonProperty("transfer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transfer")]
#endif
        public string Transfer { get; set; }
    }
}
