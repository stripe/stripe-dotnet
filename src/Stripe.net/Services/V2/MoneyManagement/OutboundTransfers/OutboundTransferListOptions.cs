// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OutboundTransferListOptions : V2.ListOptions
    {
        /// <summary>
        /// Filter for objects created after the specified timestamp. Must be an RFC 3339 date &amp;
        /// time value, for example: 2022-09-18T13:22:00Z.
        /// </summary>
        [JsonProperty("created_gt")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created_gt")]
#endif
        public DateTime? CreatedGt { get; set; }

        /// <summary>
        /// Filter for objects created on or after the specified timestamp. Must be an RFC 3339 date
        /// &amp; time value, for example: 2022-09-18T13:22:00Z.
        /// </summary>
        [JsonProperty("created_gte")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created_gte")]
#endif
        public DateTime? CreatedGte { get; set; }

        /// <summary>
        /// Filter for objects created before the specified timestamp. Must be an RFC 3339 date
        /// &amp; time value, for example: 2022-09-18T13:22:00Z.
        /// </summary>
        [JsonProperty("created_lt")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created_lt")]
#endif
        public DateTime? CreatedLt { get; set; }

        /// <summary>
        /// Filter for objects created on or before the specified timestamp. Must be an RFC 3339
        /// date &amp; time value, for example: 2022-09-18T13:22:00Z.
        /// </summary>
        [JsonProperty("created_lte")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created_lte")]
#endif
        public DateTime? CreatedLte { get; set; }

        /// <summary>
        /// Closed Enum. Only return OutboundTransfers with this status.
        /// One of: <c>canceled</c>, <c>failed</c>, <c>posted</c>, <c>processing</c>, or
        /// <c>returned</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public List<string> Status { get; set; }
    }
}
