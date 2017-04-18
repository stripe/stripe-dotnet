using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public abstract class StripeProductSharedOptions
    {
        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("attributes")]
        public string[] Attributes { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("deactivate_on")]
        public string[] DeactivateOn { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("images")]
        public string[] Images { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// REQUIRED: 
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("package_dimensions")]
        public StripePackageDimensionOptions PackageDimensions { get; set; }

        [JsonProperty("shippable")]
        public bool? Shippable { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
