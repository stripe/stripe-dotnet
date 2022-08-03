// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class OrderAutomaticTaxOptions : INestedOptions
    {
        /// <summary>
        /// Enable automatic tax calculation which will automatically compute tax rates on this
        /// order.
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
    }
}
