// File generated from our OpenAPI spec
namespace Stripe.V2.Data
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ReportGetOptions : BaseOptions
    {
        /// <summary>
        /// Any optional includes (see <a
        /// href="https://docs.stripe.com/api-includable-response-values">include-dependent response
        /// values</a>).
        /// One of: <c>default_sql</c>, or <c>parameters</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("include")]
        [STJS.JsonPropertyName("include")]
        public List<string> Include { get; set; }
    }
}
