// File generated from our OpenAPI spec
namespace Stripe.V2.Commerce
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ProductCatalogImportStatusDetailsSucceededWithErrors : StripeEntity<ProductCatalogImportStatusDetailsSucceededWithErrors>
    {
        /// <summary>
        /// The total number of records that failed to process.
        /// </summary>
        [JsonProperty("error_count")]
        [JsonConverter(typeof(Int64StringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("error_count")]
        public long ErrorCount { get; set; }

        /// <summary>
        /// A file containing details about all errors that occurred.
        /// </summary>
        [JsonProperty("error_file")]
        [STJS.JsonPropertyName("error_file")]
        public ProductCatalogImportStatusDetailsSucceededWithErrorsErrorFile ErrorFile { get; set; }

        /// <summary>
        /// A sample of errors that occurred during processing.
        /// </summary>
        [JsonProperty("samples")]
        [STJS.JsonPropertyName("samples")]
        public List<ProductCatalogImportStatusDetailsSucceededWithErrorsSample> Samples { get; set; }

        /// <summary>
        /// The total number of records processed.
        /// </summary>
        [JsonProperty("success_count")]
        [JsonConverter(typeof(Int64StringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("success_count")]
        public long SuccessCount { get; set; }
    }
}
