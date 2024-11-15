// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ProductPackageDimensionsOptions : INestedOptions
    {
        /// <summary>
        /// Height, in inches. Maximum precision is 2 decimal places.
        /// </summary>
        [JsonProperty("height")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("height")]
#endif

        public decimal? Height { get; set; }

        /// <summary>
        /// Length, in inches. Maximum precision is 2 decimal places.
        /// </summary>
        [JsonProperty("length")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("length")]
#endif

        public decimal? Length { get; set; }

        /// <summary>
        /// Weight, in ounces. Maximum precision is 2 decimal places.
        /// </summary>
        [JsonProperty("weight")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("weight")]
#endif

        public decimal? Weight { get; set; }

        /// <summary>
        /// Width, in inches. Maximum precision is 2 decimal places.
        /// </summary>
        [JsonProperty("width")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("width")]
#endif

        public decimal? Width { get; set; }
    }
}
