// File generated from our OpenAPI spec
namespace Stripe.V2.Data
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReportParametersArrayDetails : StripeEntity<ReportParametersArrayDetails>
    {
        /// <summary>
        /// The data type of the elements in the array.
        /// One of: <c>array</c>, <c>enum</c>, <c>string</c>, or <c>timestamp</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("element_type")]
        [STJS.JsonPropertyName("element_type")]
        public string ElementType { get; set; }

        /// <summary>
        /// Details about enum elements in the array.
        /// </summary>
        [JsonProperty("enum_details")]
        [STJS.JsonPropertyName("enum_details")]
        public ReportParametersArrayDetailsEnumDetails EnumDetails { get; set; }
    }
}
