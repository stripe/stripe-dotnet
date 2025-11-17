// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class EventListOptions : V2.ListOptions
    {
        /// <summary>
        /// Set of filters to query events within a range of <c>created</c> timestamps.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public EventListCreatedOptions Created { get; set; }

        /// <summary>
        /// Primary object ID used to retrieve related events.
        /// </summary>
        [JsonProperty("object_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object_id")]
#endif
        public string ObjectId { get; set; }

        /// <summary>
        /// An array of up to 20 strings containing specific event names.
        /// </summary>
        [JsonProperty("types")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("types")]
#endif
        public List<string> Types { get; set; }
    }
}
