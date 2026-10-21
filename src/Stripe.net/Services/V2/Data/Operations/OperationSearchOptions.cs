// File generated from our OpenAPI spec
namespace Stripe.V2.Data
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OperationSearchOptions : BaseOptions
    {
        /// <summary>
        /// Restrict results to public resource catalogs. Defaults to all catalogs available to the
        /// caller.
        /// One of: <c>metrics</c>, <c>reports</c>, or <c>schemas</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("catalogs")]
        [STJS.JsonPropertyName("catalogs")]
        public List<string> Catalogs { get; set; }

        /// <summary>
        /// Maximum results. Default: 5, Max: 20.
        /// </summary>
        [JsonProperty("limit")]
        [STJS.JsonPropertyName("limit")]
        public long? Limit { get; set; }

        /// <summary>
        /// The page token for pagination.
        /// </summary>
        [JsonProperty("page")]
        [STJS.JsonPropertyName("page")]
        public string Page { get; set; }

        /// <summary>
        /// Natural-language question. Required.
        /// </summary>
        [JsonProperty("query")]
        [STJS.JsonPropertyName("query")]
        public string Query { get; set; }
    }
}
