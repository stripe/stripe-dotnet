// File generated from our OpenAPI spec
namespace Stripe.V2.Commerce
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ProductCatalogImportStatusDetailsSucceeded : StripeEntity<ProductCatalogImportStatusDetailsSucceeded>
    {
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
