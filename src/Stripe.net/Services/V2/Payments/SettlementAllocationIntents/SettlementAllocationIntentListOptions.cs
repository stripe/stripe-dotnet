// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SettlementAllocationIntentListOptions : V2.ListOptions
    {
        /// <summary>
        /// Filter for objects created after the specified timestamp. Must be an RFC 3339 date &amp;
        /// time value, for example: 2025-10-17T13:22::00Z.
        /// </summary>
        [JsonProperty("created_gt")]
        [STJS.JsonPropertyName("created_gt")]
        public DateTime? CreatedGt { get; set; }

        /// <summary>
        /// Filter for objects created on or after the specified timestamp. Must be an RFC 3339 date
        /// &amp; time value, for example: 2025-10-17T13:22::00Z.
        /// </summary>
        [JsonProperty("created_gte")]
        [STJS.JsonPropertyName("created_gte")]
        public DateTime? CreatedGte { get; set; }

        /// <summary>
        /// Filter for objects created before the specified timestamp. Must be an RFC 3339 date
        /// &amp; time value, for example: 2025-10-17T13:22::00Z.
        /// </summary>
        [JsonProperty("created_lt")]
        [STJS.JsonPropertyName("created_lt")]
        public DateTime? CreatedLt { get; set; }

        /// <summary>
        /// Filter for objects created on or before the specified timestamp. Must be an RFC 3339
        /// date &amp; time value, for example: 2025-10-17T13:22::00Z.
        /// </summary>
        [JsonProperty("created_lte")]
        [STJS.JsonPropertyName("created_lte")]
        public DateTime? CreatedLte { get; set; }

        /// <summary>
        /// Filter the SettlementAllocationIntents by FinancialAccount.
        /// </summary>
        [JsonProperty("financial_account")]
        [STJS.JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Filter the SettlementAllocationIntents by status.
        /// One of: <c>canceled</c>, <c>errored</c>, <c>matched</c>, <c>pending</c>, <c>settled</c>,
        /// or <c>submitted</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
