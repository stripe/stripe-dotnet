// File generated from our OpenAPI spec
namespace Stripe.Sigma
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Contains information about the tables in a reporting Schema.
    /// </summary>
    public class Schema : StripeEntity<Schema>, IHasObject
    {
        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }

        [JsonProperty("tables")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tables")]
#endif
        public List<SchemaTable> Tables { get; set; }
    }
}
