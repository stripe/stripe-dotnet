// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ProductPackageDimensionsOptions : INestedOptions
    {
        /// <summary>
        /// Height, in inches. Maximum precision is 2 decimal places.
        /// </summary>
        [JsonProperty("height")]
        [STJS.JsonPropertyName("height")]
        public decimal? Height { get; set; }

        /// <summary>
        /// Length, in inches. Maximum precision is 2 decimal places.
        /// </summary>
        [JsonProperty("length")]
        [STJS.JsonPropertyName("length")]
        public decimal? Length { get; set; }

        /// <summary>
        /// Weight, in ounces. Maximum precision is 2 decimal places.
        /// </summary>
        [JsonProperty("weight")]
        [STJS.JsonPropertyName("weight")]
        public decimal? Weight { get; set; }

        /// <summary>
        /// Width, in inches. Maximum precision is 2 decimal places.
        /// </summary>
        [JsonProperty("width")]
        [STJS.JsonPropertyName("width")]
        public decimal? Width { get; set; }
    }
}
