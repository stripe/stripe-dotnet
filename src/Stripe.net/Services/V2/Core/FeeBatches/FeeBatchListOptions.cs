// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FeeBatchListOptions : V2.ListOptions
    {
        /// <summary>
        /// Filter to return only FeeBatches associated with this collection record ID.
        /// </summary>
        [JsonProperty("collection_record")]
        [STJS.JsonPropertyName("collection_record")]
        public string CollectionRecord { get; set; }

        /// <summary>
        /// Filter for FeeBatches created at the exact specified timestamp.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Filter for FeeBatches created after the specified timestamp (exclusive).
        /// </summary>
        [JsonProperty("created_gt")]
        [STJS.JsonPropertyName("created_gt")]
        public DateTime? CreatedGt { get; set; }

        /// <summary>
        /// Filter for FeeBatches created at or after the specified timestamp (inclusive).
        /// </summary>
        [JsonProperty("created_gte")]
        [STJS.JsonPropertyName("created_gte")]
        public DateTime? CreatedGte { get; set; }

        /// <summary>
        /// Filter for FeeBatches created before the specified timestamp (exclusive).
        /// </summary>
        [JsonProperty("created_lt")]
        [STJS.JsonPropertyName("created_lt")]
        public DateTime? CreatedLt { get; set; }

        /// <summary>
        /// Filter for FeeBatches created at or before the specified timestamp (inclusive).
        /// </summary>
        [JsonProperty("created_lte")]
        [STJS.JsonPropertyName("created_lte")]
        public DateTime? CreatedLte { get; set; }

        /// <summary>
        /// Filters FeeBatches by status. Multiple values use OR semantics. When omitted or empty,
        /// returns <c>pending</c> and <c>billed</c> FeeBatches. To return canceled FeeBatches,
        /// include <c>canceled</c>.
        /// One of: <c>billed</c>, <c>canceled</c>, or <c>pending</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("statuses")]
        [STJS.JsonPropertyName("statuses")]
        public List<string> Statuses { get; set; }
    }
}
