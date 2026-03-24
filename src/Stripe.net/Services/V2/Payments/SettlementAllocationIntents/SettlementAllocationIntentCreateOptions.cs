// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SettlementAllocationIntentCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The amount and currency of the SettlementAllocationIntent. Allowed Currencies are
        /// <c>gbp</c> | <c>eur</c>.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// Date when we expect to receive the funds. Must be in future .
        /// </summary>
        [JsonProperty("expected_settlement_date")]
        [STJS.JsonPropertyName("expected_settlement_date")]
        public DateTime? ExpectedSettlementDate { get; set; }

        /// <summary>
        /// Financial Account Id where the funds are expected for this SettlementAllocationIntent.
        /// </summary>
        [JsonProperty("financial_account")]
        [STJS.JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Metadata associated with the SettlementAllocationIntent.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Reference for the SettlementAllocationIntent. This should be same as the transaction
        /// reference used by payments processor to send funds to Stripe. Must have length between 5
        /// and 255 characters and it must be unique among existing SettlementAllocationIntents that
        /// have a non-terminal status (<c>pending</c>, <c>submitted</c>, <c>matched</c>,
        /// <c>errored</c>).
        /// </summary>
        [JsonProperty("reference")]
        [STJS.JsonPropertyName("reference")]
        public string Reference { get; set; }
    }
}
