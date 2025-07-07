// File generated from our OpenAPI spec
namespace Stripe.Sigma
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SchemaListOptions : BaseOptions
    {
        /// <summary>
        /// One of: <c>sigma</c>, or <c>stripe_data_pipeline</c>.
        /// </summary>
        [JsonProperty("product")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("product")]
#endif
        public string Product { get; set; }
    }
}
