// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// SettlementAllocationIntent resource.
    /// </summary>
    public class SettlementAllocationIntent : StripeEntity<SettlementAllocationIntent>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the SettlementAllocationIntent.
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
        /// The amount and currency of the SettlementAllocationIntent.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public SettlementAllocationIntentAmount Amount { get; set; }

        /// <summary>
        /// Timestamp at which SettlementAllocationIntent was created .
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Date when we expect to receive the funds.
        /// </summary>
        [JsonProperty("expected_settlement_date")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expected_settlement_date")]
#endif
        public DateTime ExpectedSettlementDate { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// FinancialAccount ID where the funds are expected.
        /// </summary>
        [JsonProperty("financial_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_account")]
#endif
        public string FinancialAccount { get; set; }

        /// <summary>
        /// List of ReceivedCredits that matched with the SettlementAllocationIntent.
        /// </summary>
        [JsonProperty("linked_credits")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("linked_credits")]
#endif
        public List<string> LinkedCredits { get; set; }

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
        /// Metadata associated with the SettlementAllocationIntent.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Reference for the SettlementAllocationIntent. This is the transaction reference used by
        /// payments processor to send funds to Stripe .
        /// </summary>
        [JsonProperty("reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reference")]
#endif
        public string Reference { get; set; }

        /// <summary>
        /// SettlementAllocationIntent status.
        /// One of: <c>canceled</c>, <c>errored</c>, <c>matched</c>, <c>pending</c>, <c>settled</c>,
        /// or <c>submitted</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        /// <summary>
        /// Status details for a SettlementAllocationIntent in <c>errored</c> state.
        /// </summary>
        [JsonProperty("status_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status_details")]
#endif
        public SettlementAllocationIntentStatusDetails StatusDetails { get; set; }
    }
}
