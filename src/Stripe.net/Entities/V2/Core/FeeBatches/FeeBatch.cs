// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A FeeBatch represents a settlement grouping of fees. It bridges the fee domain with
    /// actual money movement, tracking what was settled and how.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FeeBatch : StripeEntity<FeeBatch>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the FeeBatch.
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
        /// Adjustments applied to this batch.
        /// </summary>
        [JsonProperty("adjustments")]
        [STJS.JsonPropertyName("adjustments")]
        public FeeBatchAdjustments Adjustments { get; set; }

        /// <summary>
        /// The total fee amount billed in this batch.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public FeeBatchAmount Amount { get; set; }

        /// <summary>
        /// The entity that collected this batch.
        /// </summary>
        [JsonProperty("collected_by")]
        [STJS.JsonPropertyName("collected_by")]
        public FeeBatchCollectedBy CollectedBy { get; set; }

        /// <summary>
        /// The money movement records associated with collecting this batch.
        /// </summary>
        [JsonProperty("collection_records")]
        [STJS.JsonPropertyName("collection_records")]
        public List<FeeBatchCollectionRecord> CollectionRecords { get; set; }

        /// <summary>
        /// Timestamp of when this batch was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode, or <c>false</c> if in test
        /// mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The current state of this batch.
        /// One of: <c>billed</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Timestamps for each status transition.
        /// </summary>
        [JsonProperty("status_transitions")]
        [STJS.JsonPropertyName("status_transitions")]
        public FeeBatchStatusTransitions StatusTransitions { get; set; }

        /// <summary>
        /// The tax amount included in this batch.
        /// </summary>
        [JsonProperty("tax")]
        [STJS.JsonPropertyName("tax")]
        public FeeBatchTax Tax { get; set; }
    }
}
