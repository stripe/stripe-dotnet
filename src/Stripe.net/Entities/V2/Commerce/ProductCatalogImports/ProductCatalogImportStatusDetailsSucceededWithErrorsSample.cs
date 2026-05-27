// File generated from our OpenAPI spec
namespace Stripe.V2.Commerce
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ProductCatalogImportStatusDetailsSucceededWithErrorsSample : StripeEntity<ProductCatalogImportStatusDetailsSucceededWithErrorsSample>, IHasId
    {
        /// <summary>
        /// A description of what went wrong with this record.
        /// </summary>
        [JsonProperty("error_message")]
        [STJS.JsonPropertyName("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The name of the field that caused the error.
        /// </summary>
        [JsonProperty("field")]
        [STJS.JsonPropertyName("field")]
        public string Field { get; set; }

        /// <summary>
        /// The identifier of the record that failed to process.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The row number in the import file where the error occurred.
        /// </summary>
        [JsonProperty("row")]
        [JsonConverter(typeof(Int64StringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("row")]
        public long Row { get; set; }
    }
}
