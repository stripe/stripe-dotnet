// File generated from our OpenAPI spec
namespace Stripe.V2.Commerce
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ProductCatalogImportStatusDetailsProcessing : StripeEntity<ProductCatalogImportStatusDetailsProcessing>
    {
        /// <summary>
        /// The number of records that failed to process so far.
        /// </summary>
        [JsonProperty("error_count")]
        [JsonConverter(typeof(Int64StringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("error_count")]
        public long ErrorCount { get; set; }

        /// <summary>
        /// The number of records processed so far.
        /// </summary>
        [JsonProperty("success_count")]
        [JsonConverter(typeof(Int64StringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("success_count")]
        public long SuccessCount { get; set; }
    }
}
