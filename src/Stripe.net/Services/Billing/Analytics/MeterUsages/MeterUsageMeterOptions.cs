// File generated from our OpenAPI spec
namespace Stripe.Billing.Analytics
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class MeterUsageMeterOptions : INestedOptions
    {
        /// <summary>
        /// Key-value pairs used to filter usage events by meter dimension values. Each value is an
        /// array that can include multiple values for the key. If specified, usage is filtered for
        /// matching usage events.
        /// </summary>
        [JsonProperty("dimension_filters")]
        [STJS.JsonPropertyName("dimension_filters")]
        public Dictionary<string, List<string>> DimensionFilters { get; set; }

        /// <summary>
        /// List of meter dimension keys to group by. If specified, usage events will be grouped by
        /// the given meter dimension key's values.
        /// </summary>
        [JsonProperty("dimension_group_by_keys")]
        [STJS.JsonPropertyName("dimension_group_by_keys")]
        public List<string> DimensionGroupByKeys { get; set; }

        /// <summary>
        /// Meter id to query usage for.
        /// </summary>
        [JsonProperty("meter")]
        [STJS.JsonPropertyName("meter")]
        public string Meter { get; set; }

        /// <summary>
        /// Key-value pairs used to filter usage events by high cardinality tenant dimension values.
        /// Each value is an array that can include multiple values for the key. If specified, usage
        /// is filtered for matching usage events.
        /// </summary>
        [JsonProperty("tenant_filters")]
        [STJS.JsonPropertyName("tenant_filters")]
        public Dictionary<string, List<string>> TenantFilters { get; set; }
    }
}
