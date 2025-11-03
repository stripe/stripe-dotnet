// File generated from our OpenAPI spec
namespace Stripe.V2.Reporting
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReportParameters : StripeEntity<ReportParameters>
    {
        /// <summary>
        /// For array parameters, provides details about the array elements.
        /// </summary>
        [JsonProperty("array_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("array_details")]
#endif
        public ReportParametersArrayDetails ArrayDetails { get; set; }

        /// <summary>
        /// Explains the purpose and usage of the parameter.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// For enum parameters, provides the list of allowed values.
        /// </summary>
        [JsonProperty("enum_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enum_details")]
#endif
        public ReportParametersEnumDetails EnumDetails { get; set; }

        /// <summary>
        /// Indicates whether the parameter must be provided.
        /// </summary>
        [JsonProperty("required")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("required")]
#endif
        public bool Required { get; set; }

        /// <summary>
        /// For timestamp parameters, specifies the allowed date range.
        /// </summary>
        [JsonProperty("timestamp_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("timestamp_details")]
#endif
        public ReportParametersTimestampDetails TimestampDetails { get; set; }

        /// <summary>
        /// The data type of the parameter.
        /// One of: <c>array</c>, <c>enum</c>, <c>string</c>, or <c>timestamp</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
