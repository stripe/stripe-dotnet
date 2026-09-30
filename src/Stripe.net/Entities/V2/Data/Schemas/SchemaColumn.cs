// File generated from our OpenAPI spec
namespace Stripe.V2.Data
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SchemaColumn : StripeEntity<SchemaColumn>
    {
        /// <summary>
        /// A description of what the column represents.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Columns in other schemas that reference this column as a foreign key.
        /// </summary>
        [JsonProperty("foreign_keys_from")]
        [STJS.JsonPropertyName("foreign_keys_from")]
        public List<SchemaColumnForeignKeysFrom> ForeignKeysFrom { get; set; }

        /// <summary>
        /// Columns in other schemas that this column references as a foreign key.
        /// </summary>
        [JsonProperty("foreign_keys_to")]
        [STJS.JsonPropertyName("foreign_keys_to")]
        public List<SchemaColumnForeignKeysTo> ForeignKeysTo { get; set; }

        /// <summary>
        /// Whether the column forms part of the table's primary key.
        /// </summary>
        [JsonProperty("is_primary_key")]
        [STJS.JsonPropertyName("is_primary_key")]
        public bool IsPrimaryKey { get; set; }

        /// <summary>
        /// The name of the column.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The data type of the column.
        /// One of: <c>bigint</c>, <c>boolean</c>, <c>date</c>, <c>datetime</c>, <c>decimal</c>,
        /// <c>double</c>, <c>integer</c>, <c>timestamp</c>, or <c>varchar</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
