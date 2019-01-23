namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    public class PackageDimensions : StripeEntity<PackageDimensions>
    {
        [JsonProperty("height")]
        public decimal? Height { get; set; }

        [JsonProperty("length")]
        public decimal? Length { get; set; }

        [JsonProperty("weight")]
        public decimal? Weight { get; set; }

        [JsonProperty("width")]
        public decimal? Width { get; set; }
    }
}
