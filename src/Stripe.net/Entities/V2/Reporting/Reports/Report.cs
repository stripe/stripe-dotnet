// File generated from our OpenAPI spec
namespace Stripe.V2.Reporting
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// The Report resource represents a customizable report template that provides insights
    /// into various aspects of your Stripe integration.
    /// </summary>
    public class Report : StripeEntity<Report>, IHasId, IHasObject
    {
        /// <summary>
        /// The unique identifier of the <c>Report</c> object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// The human-readable name of the <c>Report</c>.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }

        /// <summary>
        /// Specification of the parameters that the <c>Report</c> accepts. It details each
        /// parameter's name, description, whether it is required, and any validations performed.
        /// </summary>
        [JsonProperty("parameters")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("parameters")]
#endif
        public Dictionary<string, ReportParameters> Parameters { get; set; }
    }
}
