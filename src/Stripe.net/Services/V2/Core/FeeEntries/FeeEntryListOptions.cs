// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FeeEntryListOptions : V2.ListOptions
    {
        /// <summary>
        /// Filter by money movement id (e.g. txn_xxx, bt_xxx).
        /// </summary>
        [JsonProperty("collection_record")]
        [STJS.JsonPropertyName("collection_record")]
        public string CollectionRecord { get; set; }

        /// <summary>
        /// Filter for FeeEntries created at the exact specified timestamp.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Filter for FeeEntries created after the specified timestamp (exclusive).
        /// </summary>
        [JsonProperty("created_gt")]
        [STJS.JsonPropertyName("created_gt")]
        public DateTime? CreatedGt { get; set; }

        /// <summary>
        /// Filter for FeeEntries created at or after the specified timestamp (inclusive).
        /// </summary>
        [JsonProperty("created_gte")]
        [STJS.JsonPropertyName("created_gte")]
        public DateTime? CreatedGte { get; set; }

        /// <summary>
        /// Filter for FeeEntries created before the specified timestamp (exclusive).
        /// </summary>
        [JsonProperty("created_lt")]
        [STJS.JsonPropertyName("created_lt")]
        public DateTime? CreatedLt { get; set; }

        /// <summary>
        /// Filter for FeeEntries created at or before the specified timestamp (inclusive).
        /// </summary>
        [JsonProperty("created_lte")]
        [STJS.JsonPropertyName("created_lte")]
        public DateTime? CreatedLte { get; set; }

        /// <summary>
        /// Filter by fee batch id (fb_xxx).
        /// </summary>
        [JsonProperty("fee_batch")]
        [STJS.JsonPropertyName("fee_batch")]
        public string FeeBatch { get; set; }

        /// <summary>
        /// Filter by usage object id (e.g. ch_xxx, py_xxx).
        /// </summary>
        [JsonProperty("incurred_by")]
        [STJS.JsonPropertyName("incurred_by")]
        public string IncurredBy { get; set; }
    }
}
