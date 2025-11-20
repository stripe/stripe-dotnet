// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class EventListCreatedOptions : INestedOptions
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
    }
}
