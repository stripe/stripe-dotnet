// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TransactionEntryBalanceImpact : StripeEntity<TransactionEntryBalanceImpact>
    {
        /// <summary>
        /// Impact to the available balance.
        /// </summary>
        [JsonProperty("available")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("available")]
#endif
        public V2.Amount Available { get; set; }

        /// <summary>
        /// Impact to the inbound_pending balance.
        /// </summary>
        [JsonProperty("inbound_pending")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("inbound_pending")]
#endif
        public V2.Amount InboundPending { get; set; }

        /// <summary>
        /// Impact to the outbound_pending balance.
        /// </summary>
        [JsonProperty("outbound_pending")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("outbound_pending")]
#endif
        public V2.Amount OutboundPending { get; set; }
    }
}
