// File generated from our OpenAPI spec
namespace Stripe.V2.Data.Reporting
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class QueryRunGetOptions : BaseOptions
    {
        /// <summary>
        /// Any optional includes (see https://docs.stripe.com/api-includable-response-values).
        /// One of: <c>result.file.schema</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("include")]
        [STJS.JsonPropertyName("include")]
        public List<string> Include { get; set; }
    }
}
