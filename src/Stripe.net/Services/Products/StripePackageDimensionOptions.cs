using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripePackageDimensionOptions : INestedOptions
    {
        [JsonProperty("package_dimensions[height]")]
        public decimal? Height { get; set; }

        [JsonProperty("package_dimensions[length]")]
        public decimal? Length { get; set; }

        [JsonProperty("package_dimensions[weight]")]
        public decimal? Weight { get; set; }

        [JsonProperty("package_dimensions[width]")]
        public decimal? Width { get; set; }
    }
}
