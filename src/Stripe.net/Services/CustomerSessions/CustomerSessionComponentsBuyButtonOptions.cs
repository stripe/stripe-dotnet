// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class CustomerSessionComponentsBuyButtonOptions : INestedOptions
    {
        /// <summary>
        /// Whether the buy button is enabled.
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
    }
}
