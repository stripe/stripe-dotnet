// File generated from our OpenAPI spec
namespace Stripe.V2.Data
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// The <c>Schema</c> resource describes the columns, types, and relationships of a table
    /// that can be queried.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Schema : StripeEntity<Schema>, IHasId, IHasObject
    {
        /// <summary>
        /// The unique identifier of the <c>Schema</c>.
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
        /// The columns of the table.
        /// </summary>
        [JsonProperty("columns")]
        [STJS.JsonPropertyName("columns")]
        public List<SchemaColumn> Columns { get; set; }

        /// <summary>
        /// The dataset the table belongs to.
        /// One of: <c>analytical</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("dataset")]
        [STJS.JsonPropertyName("dataset")]
        public string Dataset { get; set; }

        /// <summary>
        /// A description of the table.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// An extended, LLM-friendly description of the table, useful for query generation.
        /// </summary>
        [JsonProperty("extended_description")]
        [STJS.JsonPropertyName("extended_description")]
        public string ExtendedDescription { get; set; }

        /// <summary>
        /// Whether this <c>Schema</c> describes live mode data.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The human-readable name of the table.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Time at which the table's schema was last refreshed.
        /// </summary>
        [JsonProperty("refreshed_at")]
        [STJS.JsonPropertyName("refreshed_at")]
        public DateTime RefreshedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Reports relevant to this table.
        /// </summary>
        [JsonProperty("relevant_reports")]
        [STJS.JsonPropertyName("relevant_reports")]
        public List<SchemaRelevantReport> RelevantReports { get; set; }
    }
}
