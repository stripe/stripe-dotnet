// File generated from our OpenAPI spec
namespace Stripe.V2.Commerce
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ProductCatalogImportStatusDetailsFailed : StripeEntity<ProductCatalogImportStatusDetailsFailed>
    {
        /// <summary>
        /// The error code for this product catalog processing failure.
        /// One of: <c>file_not_found</c>, <c>internal_error</c>, or <c>invalid_file</c>.
        /// </summary>
        [JsonProperty("code")]
        [STJS.JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// A message explaining why the import failed.
        /// </summary>
        [JsonProperty("failure_message")]
        [STJS.JsonPropertyName("failure_message")]
        public string FailureMessage { get; set; }

        /// <summary>
        /// The error type for this product catalog processing failure.
        /// One of: <c>cannot_proceed</c>, or <c>transient_failure</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
