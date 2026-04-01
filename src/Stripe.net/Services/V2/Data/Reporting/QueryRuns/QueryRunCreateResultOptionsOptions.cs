// File generated from our OpenAPI spec
namespace Stripe.V2.Data.Reporting
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class QueryRunCreateResultOptionsOptions : INestedOptions
    {
        /// <summary>
        /// If set, the generated results file will be compressed into a ZIP folder. This is useful
        /// for reducing file size and download time for large results.
        /// </summary>
        [JsonProperty("compress_file")]
        [STJS.JsonPropertyName("compress_file")]
        public bool? CompressFile { get; set; }
    }
}
