// File generated from our OpenAPI spec
namespace Stripe.V2.Extend
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ObjectDefinitionVersionPropertiesItems : StripeEntity<ObjectDefinitionVersionPropertiesItems>
    {
        /// <summary>
        /// A required list of values for enum types.
        /// </summary>
        [JsonProperty("allowed_values")]
        [STJS.JsonPropertyName("allowed_values")]
        public List<string> AllowedValues { get; set; }

        /// <summary>
        /// An optional default value for the field.
        /// </summary>
        [JsonProperty("default_value")]
        [STJS.JsonPropertyName("default_value")]
        public object DefaultValue { get; set; }

        /// <summary>
        /// An optional human-readable description of the field.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// An optional exclusive maximum value for integer or decimal types.
        /// </summary>
        [JsonProperty("exclusive_maximum")]
        [STJS.JsonPropertyName("exclusive_maximum")]
        public object ExclusiveMaximum { get; set; }

        /// <summary>
        /// An optional exclusive minimum value for integer or decimal types.
        /// </summary>
        [JsonProperty("exclusive_minimum")]
        [STJS.JsonPropertyName("exclusive_minimum")]
        public object ExclusiveMinimum { get; set; }

        /// <summary>
        /// Whether or not the field is deprecated (default false).
        /// </summary>
        [JsonProperty("is_deprecated")]
        [STJS.JsonPropertyName("is_deprecated")]
        public bool? IsDeprecated { get; set; }

        /// <summary>
        /// The required scalar schema for each array item. Array values retain their supplied
        /// order, and order is significant. Values are never sorted. Empty arrays are valid unless
        /// min_items is positive.
        /// </summary>
        [JsonProperty("items")]
        [STJS.JsonPropertyName("items")]
        public ObjectDefinitionVersionPropertiesItemsItems Items { get; set; }

        /// <summary>
        /// An optional maximum number of array items. It defaults to and cannot exceed 100.
        /// </summary>
        [JsonProperty("max_items")]
        [STJS.JsonPropertyName("max_items")]
        public long? MaxItems { get; set; }

        /// <summary>
        /// An optional maximum length validation for string fields.
        /// </summary>
        [JsonProperty("max_length")]
        [STJS.JsonPropertyName("max_length")]
        public long? MaxLength { get; set; }

        /// <summary>
        /// An optional maximum value for integer or decimal types.
        /// </summary>
        [JsonProperty("maximum")]
        [STJS.JsonPropertyName("maximum")]
        public object Maximum { get; set; }

        /// <summary>
        /// An optional minimum number of array items. Empty arrays are valid when this is absent or
        /// zero.
        /// </summary>
        [JsonProperty("min_items")]
        [STJS.JsonPropertyName("min_items")]
        public long? MinItems { get; set; }

        /// <summary>
        /// An optional minimum length validation for string fields.
        /// </summary>
        [JsonProperty("min_length")]
        [STJS.JsonPropertyName("min_length")]
        public long? MinLength { get; set; }

        /// <summary>
        /// An optional minimum value for integer or decimal types.
        /// </summary>
        [JsonProperty("minimum")]
        [STJS.JsonPropertyName("minimum")]
        public object Minimum { get; set; }

        /// <summary>
        /// The type referenced by object reference fields.
        /// </summary>
        [JsonProperty("referenced_type")]
        [STJS.JsonPropertyName("referenced_type")]
        public string ReferencedType { get; set; }

        /// <summary>
        /// Whether or not the field is required (default false).
        /// </summary>
        [JsonProperty("required")]
        [STJS.JsonPropertyName("required")]
        public bool? Required { get; set; }

        /// <summary>
        /// An optional human-readable name for the field.
        /// </summary>
        [JsonProperty("title")]
        [STJS.JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// The data type of the field.
        /// One of: <c>array</c>, <c>boolean</c>, <c>currency</c>, <c>datetime</c>, <c>decimal</c>,
        /// <c>enum</c>, <c>integer</c>, <c>monetary_amount</c>, <c>object_reference</c>, or
        /// <c>string</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Whether array item values must be unique (default false). Duplicate values are allowed
        /// by default.
        /// </summary>
        [JsonProperty("unique_items")]
        [STJS.JsonPropertyName("unique_items")]
        public bool? UniqueItems { get; set; }
    }
}
