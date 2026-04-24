// File generated from our OpenAPI spec
namespace Stripe.V2.Commerce
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ProductCatalogImportStatusDetails : StripeEntity<ProductCatalogImportStatusDetails>
    {
        /// <summary>
        /// Details when the import is awaiting file upload.
        /// </summary>
        [JsonProperty("awaiting_upload")]
        [STJS.JsonPropertyName("awaiting_upload")]
        public ProductCatalogImportStatusDetailsAwaitingUpload AwaitingUpload { get; set; }

        /// <summary>
        /// Details when the import didn't complete.
        /// </summary>
        [JsonProperty("failed")]
        [STJS.JsonPropertyName("failed")]
        public ProductCatalogImportStatusDetailsFailed Failed { get; set; }

        /// <summary>
        /// Details when the import is processing.
        /// </summary>
        [JsonProperty("processing")]
        [STJS.JsonPropertyName("processing")]
        public ProductCatalogImportStatusDetailsProcessing Processing { get; set; }

        /// <summary>
        /// Details when the import has succeeded.
        /// </summary>
        [JsonProperty("succeeded")]
        [STJS.JsonPropertyName("succeeded")]
        public ProductCatalogImportStatusDetailsSucceeded Succeeded { get; set; }

        /// <summary>
        /// Details when the import completed but some records failed to process.
        /// </summary>
        [JsonProperty("succeeded_with_errors")]
        [STJS.JsonPropertyName("succeeded_with_errors")]
        public ProductCatalogImportStatusDetailsSucceededWithErrors SucceededWithErrors { get; set; }
    }
}
