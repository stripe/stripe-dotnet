// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class EventListOptions : V2.ListOptions
    {
        /// <summary>
        /// Filter for events created after the specified timestamp.
        /// </summary>
        [JsonProperty("gt")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("gt")]
#endif
        public DateTime? Gt { get; set; }

        /// <summary>
        /// Filter for events created at or after the specified timestamp.
        /// </summary>
        [JsonProperty("gte")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("gte")]
#endif
        public DateTime? Gte { get; set; }

        /// <summary>
        /// Filter for events created before the specified timestamp.
        /// </summary>
        [JsonProperty("lt")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lt")]
#endif
        public DateTime? Lt { get; set; }

        /// <summary>
        /// Filter for events created at or before the specified timestamp.
        /// </summary>
        [JsonProperty("lte")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lte")]
#endif
        public DateTime? Lte { get; set; }

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
