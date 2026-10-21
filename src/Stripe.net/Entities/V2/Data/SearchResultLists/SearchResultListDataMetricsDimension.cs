// File generated from our OpenAPI spec
namespace Stripe.V2.Data
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SearchResultListDataMetricsDimension : StripeEntity<SearchResultListDataMetricsDimension>
    {
        /// <summary>
        /// A description of what the dimension represents.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The public dimension name accepted by the metric query endpoint.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
