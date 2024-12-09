namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PackageDimensionOptions : INestedOptions
    {
        [JsonProperty("height")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("height")]
#endif
        public decimal? Height { get; set; }

        [JsonProperty("length")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("length")]
#endif
        public decimal? Length { get; set; }

        [JsonProperty("weight")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("weight")]
#endif
        public decimal? Weight { get; set; }

        [JsonProperty("width")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("width")]
#endif
        public decimal? Width { get; set; }
    }
}
