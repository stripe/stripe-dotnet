// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class CustomerSessionComponentsPricingTableOptions : INestedOptions
    {
        /// <summary>
        /// Whether the pricing table is enabled.
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
    }
}
