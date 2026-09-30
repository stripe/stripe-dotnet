// File generated from our OpenAPI spec
namespace Stripe.V2.Data
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// The <c>Report</c> resource represents a Stripe-defined, parameterized report that
    /// provides insights into various aspects of your Stripe integration.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Report : StripeEntity<Report>, IHasId, IHasObject
    {
        /// <summary>
        /// The unique identifier of the <c>Report</c>.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Representative SQL generated using common parameter values, or an explanatory message
        /// when the report's SQL cannot be exposed. Only present when requested via
        /// <c>include[0]=default_sql</c>.
        /// </summary>
        [JsonProperty("default_sql")]
        [STJS.JsonPropertyName("default_sql")]
        public string DefaultSql { get; set; }

        /// <summary>
        /// A human-readable description of what this report contains.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Whether this <c>Report</c> is available in live mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The human-readable name of the <c>Report</c>.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Specification of the parameters that the <c>Report</c> accepts, keyed by parameter name.
        /// </summary>
        [JsonProperty("parameters")]
        [STJS.JsonPropertyName("parameters")]
        public Dictionary<string, ReportParameters> Parameters { get; set; }
    }
}
