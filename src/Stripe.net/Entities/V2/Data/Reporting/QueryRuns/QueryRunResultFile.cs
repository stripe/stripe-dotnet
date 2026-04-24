// File generated from our OpenAPI spec
namespace Stripe.V2.Data.Reporting
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QueryRunResultFile : StripeEntity<QueryRunResultFile>
    {
        /// <summary>
        /// The content type of the file.
        /// One of: <c>csv</c>, or <c>zip</c>.
        /// </summary>
        [JsonProperty("content_type")]
        [STJS.JsonPropertyName("content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// A pre-signed URL that allows secure, time-limited access to download the file.
        /// </summary>
        [JsonProperty("download_url")]
        [STJS.JsonPropertyName("download_url")]
        public QueryRunResultFileDownloadUrl DownloadUrl { get; set; }

        /// <summary>
        /// The total size of the file in bytes.
        /// </summary>
        [JsonProperty("size")]
        [JsonConverter(typeof(Int64StringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("size")]
        public long Size { get; set; }
    }
}
