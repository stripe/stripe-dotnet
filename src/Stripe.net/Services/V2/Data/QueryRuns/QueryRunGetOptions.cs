// File generated from our OpenAPI spec
namespace Stripe.V2.Data
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class QueryRunGetOptions : BaseOptions
    {
        /// <summary>
        /// Any optional includes (see <a
        /// href="https://docs.stripe.com/api-includable-response-values">include-dependent response
        /// values</a>).
        /// One of: <c>result.inline</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("include")]
        [STJS.JsonPropertyName("include")]
        public List<string> Include { get; set; }

        /// <summary>
        /// The maximum number of inline <c>QueryRun</c> result rows to return. Defaults to 10.
        /// Maximum is 1000.
        /// </summary>
        [JsonProperty("limit")]
        [STJS.JsonPropertyName("limit")]
        public long? Limit { get; set; }

        /// <summary>
        /// The page token for paginating the inline <c>QueryRun</c> result rows.
        /// </summary>
        [JsonProperty("page")]
        [STJS.JsonPropertyName("page")]
        public string Page { get; set; }
    }
}
