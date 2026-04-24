// File generated from our OpenAPI spec
namespace Stripe.V2.Commerce
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ProductCatalogImportStatusDetailsSucceededWithErrorsErrorFile : StripeEntity<ProductCatalogImportStatusDetailsSucceededWithErrorsErrorFile>
    {
        /// <summary>
        /// The MIME type of the error file.
        /// </summary>
        [JsonProperty("content_type")]
        [STJS.JsonPropertyName("content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// The pre-signed URL information for downloading the error file.
        /// </summary>
        [JsonProperty("download_url")]
        [STJS.JsonPropertyName("download_url")]
        public ProductCatalogImportStatusDetailsSucceededWithErrorsErrorFileDownloadUrl DownloadUrl { get; set; }

        /// <summary>
        /// The size of the error file in bytes.
        /// </summary>
        [JsonProperty("size")]
        [JsonConverter(typeof(Int64StringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("size")]
        public long Size { get; set; }
    }
}
