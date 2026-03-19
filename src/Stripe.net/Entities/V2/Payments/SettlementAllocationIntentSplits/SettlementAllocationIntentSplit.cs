// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// SettlementAllocationIntentSplit resource.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SettlementAllocationIntentSplit : StripeEntity<SettlementAllocationIntentSplit>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the SettlementAllocationIntentSplit.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The account id against which the SettlementAllocationIntentSplit should be settled.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// The amount and currency of the SettlementAllocationIntentSplit.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// Timestamp at which SettlementAllocationIntentSplit was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Details about the Flow object that settled the split.
        /// </summary>
        [JsonProperty("flow")]
        [STJS.JsonPropertyName("flow")]
        public SettlementAllocationIntentSplitFlow Flow { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The ID of the SettlementAllocationIntent that this split belongs too.
        /// </summary>
        [JsonProperty("settlement_allocation_intent")]
        [STJS.JsonPropertyName("settlement_allocation_intent")]
        public string SettlementAllocationIntent { get; set; }

        /// <summary>
        /// The status of the SettlementAllocationIntentSplit.
        /// One of: <c>canceled</c>, <c>pending</c>, or <c>settled</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// The type of the SettlementAllocationIntentSplit.
        /// One of: <c>credit</c>, or <c>debit</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
