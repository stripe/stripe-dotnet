namespace Stripe
{
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    public class PackageDimensions : StripeEntity<PackageDimensions>
    {
        [JsonProperty("height")]
        [STJS.JsonPropertyName("height")]
        public decimal? Height { get; set; }

        [JsonProperty("length")]
        [STJS.JsonPropertyName("length")]
        public decimal? Length { get; set; }

        [JsonProperty("weight")]
        [STJS.JsonPropertyName("weight")]
        public decimal? Weight { get; set; }

        [JsonProperty("width")]
        [STJS.JsonPropertyName("width")]
        public decimal? Width { get; set; }
    }
}
