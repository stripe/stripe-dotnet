// File generated from our OpenAPI spec
namespace Stripe.V2.Data
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SchemaListOptions : V2.ListOptions
    {
        /// <summary>
        /// If supplied, only return schemas belonging to this dataset.
        /// One of: <c>analytical</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("dataset")]
        [STJS.JsonPropertyName("dataset")]
        public string Dataset { get; set; }

        /// <summary>
        /// Any optional includes (see https://docs.stripe.com/api-includable-response-values).
        /// One of: <c>columns</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("include")]
        [STJS.JsonPropertyName("include")]
        public List<string> Include { get; set; }

        /// <summary>
        /// If supplied, only return schemas with this name.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
