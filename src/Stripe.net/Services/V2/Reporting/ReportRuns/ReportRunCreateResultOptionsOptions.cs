// File generated from our OpenAPI spec
namespace Stripe.V2.Reporting
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ReportRunCreateResultOptionsOptions : INestedOptions
    {
        /// <summary>
        /// If set, the generated report file will be compressed into a ZIP folder. This is useful
        /// for reducing file size and download time for large reports.
        /// </summary>
        [JsonProperty("compress_file")]
        [STJS.JsonPropertyName("compress_file")]
        public bool? CompressFile { get; set; }
    }
}
