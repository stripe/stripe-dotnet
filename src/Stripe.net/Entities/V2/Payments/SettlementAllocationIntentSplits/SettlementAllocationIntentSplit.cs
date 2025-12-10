// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// SettlementAllocationIntentSplit resource.
    /// </summary>
    public class SettlementAllocationIntentSplit : StripeEntity<SettlementAllocationIntentSplit>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the SettlementAllocationIntentSplit.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// The ID of the account that will be used for the debit/credit.
        /// </summary>
        [JsonProperty("account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account")]
#endif
        public string Account { get; set; }

        /// <summary>
        /// The amount and currency of the SettlementAllocationIntentSplit.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public SettlementAllocationIntentSplitAmount Amount { get; set; }

        /// <summary>
        /// Timestamp at which SettlementAllocationIntentSplit was created.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Details about the Flow object that settled the split.
        /// </summary>
        [JsonProperty("flow")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("flow")]
#endif
        public SettlementAllocationIntentSplitFlow Flow { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// The ID of the SettlementAllocationIntent that this split belongs too.
        /// </summary>
        [JsonProperty("settlement_allocation_intent")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("settlement_allocation_intent")]
#endif
        public string SettlementAllocationIntent { get; set; }

        /// <summary>
        /// The status of the SettlementAllocationIntentSplit.
        /// One of: <c>canceled</c>, <c>pending</c>, or <c>settled</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        /// <summary>
        /// The type of the SettlementAllocationIntentSplit.
        /// One of: <c>credit</c>, or <c>debit</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
