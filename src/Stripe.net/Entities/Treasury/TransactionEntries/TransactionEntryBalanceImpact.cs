// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class TransactionEntryBalanceImpact : StripeEntity<TransactionEntryBalanceImpact>
    {
        /// <summary>
        /// The change made to funds the user can spend right now.
        /// </summary>
        [JsonProperty("cash")]
        [STJS.JsonPropertyName("cash")]
        public long Cash { get; set; }

        /// <summary>
        /// The change made to funds that are not spendable yet, but will become available at a
        /// later time.
        /// </summary>
        [JsonProperty("inbound_pending")]
        [STJS.JsonPropertyName("inbound_pending")]
        public long InboundPending { get; set; }

        /// <summary>
        /// The change made to funds in the account, but not spendable because they are being held
        /// for pending outbound flows.
        /// </summary>
        [JsonProperty("outbound_pending")]
        [STJS.JsonPropertyName("outbound_pending")]
        public long OutboundPending { get; set; }
    }
}
