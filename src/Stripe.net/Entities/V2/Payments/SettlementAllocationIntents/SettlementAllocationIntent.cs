// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    /// <summary>
    /// SettlementAllocationIntent resource.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SettlementAllocationIntent : StripeEntity<SettlementAllocationIntent>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the SettlementAllocationIntent.
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
        /// The amount and currency of the SettlementAllocationIntent.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// Timestamp at which SettlementAllocationIntent was created .
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Date when we expect to receive the funds.
        /// </summary>
        [JsonProperty("expected_settlement_date")]
        [STJS.JsonPropertyName("expected_settlement_date")]
        public DateTime ExpectedSettlementDate { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// FinancialAccount ID where the funds are expected.
        /// </summary>
        [JsonProperty("financial_account")]
        [STJS.JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// List of ReceivedCredits that matched with the SettlementAllocationIntent.
        /// </summary>
        [JsonProperty("linked_credits")]
        [STJS.JsonPropertyName("linked_credits")]
        public List<string> LinkedCredits { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Metadata associated with the SettlementAllocationIntent.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Reference for the SettlementAllocationIntent. This is the transaction reference used by
        /// payments processor to send funds to Stripe .
        /// </summary>
        [JsonProperty("reference")]
        [STJS.JsonPropertyName("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// SettlementAllocationIntent status.
        /// One of: <c>canceled</c>, <c>errored</c>, <c>matched</c>, <c>pending</c>, <c>settled</c>,
        /// or <c>submitted</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Status details for a SettlementAllocationIntent in <c>errored</c> state.
        /// </summary>
        [JsonProperty("status_details")]
        [STJS.JsonPropertyName("status_details")]
        public SettlementAllocationIntentStatusDetails StatusDetails { get; set; }
    }
}
