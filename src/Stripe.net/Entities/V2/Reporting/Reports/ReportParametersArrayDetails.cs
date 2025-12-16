// File generated from our OpenAPI spec
namespace Stripe.V2.Reporting
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReportParametersArrayDetails : StripeEntity<ReportParametersArrayDetails>
    {
        /// <summary>
        /// Data type of the elements in the array.
        /// </summary>
        [JsonProperty("element_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("element_type")]
#endif
        public string ElementType { get; set; }

        /// <summary>
        /// Details about enum elements in the array.
        /// </summary>
        [JsonProperty("enum_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enum_details")]
#endif
        public ReportParametersArrayDetailsEnumDetails EnumDetails { get; set; }
    }
}
