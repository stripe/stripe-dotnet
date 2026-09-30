// File generated from our OpenAPI spec
namespace Stripe.V2.Data
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReportParameters : StripeEntity<ReportParameters>
    {
        /// <summary>
        /// For array parameters, provides details about the array elements.
        /// </summary>
        [JsonProperty("array_details")]
        [STJS.JsonPropertyName("array_details")]
        public ReportParametersArrayDetails ArrayDetails { get; set; }

        /// <summary>
        /// Explains the purpose and usage of the parameter.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// For enum parameters, provides the list of allowed values.
        /// </summary>
        [JsonProperty("enum_details")]
        [STJS.JsonPropertyName("enum_details")]
        public ReportParametersEnumDetails EnumDetails { get; set; }

        /// <summary>
        /// Indicates whether the parameter must be provided.
        /// </summary>
        [JsonProperty("required")]
        [STJS.JsonPropertyName("required")]
        public bool Required { get; set; }

        /// <summary>
        /// The data type of the parameter.
        /// One of: <c>array</c>, <c>enum</c>, <c>string</c>, or <c>timestamp</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
