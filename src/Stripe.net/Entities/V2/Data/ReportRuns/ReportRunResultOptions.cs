// File generated from our OpenAPI spec
namespace Stripe.V2.Data
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReportRunResultOptions : StripeEntity<ReportRunResultOptions>
    {
        /// <summary>
        /// If set, the generated result file is compressed into a ZIP archive before it is stored.
        /// This applies only to downloadable file results.
        /// </summary>
        [JsonProperty("compress_file")]
        [STJS.JsonPropertyName("compress_file")]
        public bool? CompressFile { get; set; }
    }
}
