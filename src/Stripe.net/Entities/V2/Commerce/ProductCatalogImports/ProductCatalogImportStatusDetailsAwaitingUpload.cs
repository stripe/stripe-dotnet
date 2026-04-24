// File generated from our OpenAPI spec
namespace Stripe.V2.Commerce
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ProductCatalogImportStatusDetailsAwaitingUpload : StripeEntity<ProductCatalogImportStatusDetailsAwaitingUpload>
    {
        /// <summary>
        /// The pre-signed URL information for uploading the catalog file.
        /// </summary>
        [JsonProperty("upload_url")]
        [STJS.JsonPropertyName("upload_url")]
        public ProductCatalogImportStatusDetailsAwaitingUploadUploadUrl UploadUrl { get; set; }
    }
}
