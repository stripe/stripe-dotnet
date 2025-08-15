// File generated from our OpenAPI spec
namespace Stripe.V2.Reporting
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReportRunReportParameters : StripeEntity<ReportRunReportParameters>
    {
        /// <summary>
        /// Parameter with an array data type.
        /// </summary>
        [JsonProperty("array_value")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("array_value")]
#endif
        public ReportRunReportParametersArrayValue ArrayValue { get; set; }

        /// <summary>
        /// Parameter with a string data type.
        /// </summary>
        [JsonProperty("string_value")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("string_value")]
#endif
        public string StringValue { get; set; }

        /// <summary>
        /// Parameter with a timestamp data type.
        /// </summary>
        [JsonProperty("timestamp_value")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("timestamp_value")]
#endif
        public DateTime? TimestampValue { get; set; }
    }
}
