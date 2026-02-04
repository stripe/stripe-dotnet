// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SettlementAllocationIntentListOptions : V2.ListOptions
    {
        /// <summary>
        /// Filter for objects created after the specified timestamp. Must be an RFC 3339 date &amp;
        /// time value, for example: 2025-10-17T13:22::00Z.
        /// </summary>
        [JsonProperty("created_gt")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created_gt")]
#endif
        public DateTime? CreatedGt { get; set; }

        /// <summary>
        /// Filter for objects created on or after the specified timestamp. Must be an RFC 3339 date
        /// &amp; time value, for example: 2025-10-17T13:22::00Z.
        /// </summary>
        [JsonProperty("created_gte")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created_gte")]
#endif
        public DateTime? CreatedGte { get; set; }

        /// <summary>
        /// Filter for objects created before the specified timestamp. Must be an RFC 3339 date
        /// &amp; time value, for example: 2025-10-17T13:22::00Z.
        /// </summary>
        [JsonProperty("created_lt")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created_lt")]
#endif
        public DateTime? CreatedLt { get; set; }

        /// <summary>
        /// Filter for objects created on or before the specified timestamp. Must be an RFC 3339
        /// date &amp; time value, for example: 2025-10-17T13:22::00Z.
        /// </summary>
        [JsonProperty("created_lte")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created_lte")]
#endif
        public DateTime? CreatedLte { get; set; }

        /// <summary>
        /// Filter the SettlementAllocationIntents by FinancialAccount.
        /// </summary>
        [JsonProperty("financial_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_account")]
#endif
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Filter the SettlementAllocationIntents by status.
        /// One of: <c>canceled</c>, <c>errored</c>, <c>matched</c>, <c>pending</c>, <c>settled</c>,
        /// or <c>submitted</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }
    }
}
