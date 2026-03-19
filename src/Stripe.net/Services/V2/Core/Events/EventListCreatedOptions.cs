// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class EventListCreatedOptions : INestedOptions
    {
        /// <summary>
        /// Filter for events created after the specified timestamp.
        /// </summary>
        [JsonProperty("gt")]
        [STJS.JsonPropertyName("gt")]
        public DateTime? Gt { get; set; }

        /// <summary>
        /// Filter for events created at or after the specified timestamp.
        /// </summary>
        [JsonProperty("gte")]
        [STJS.JsonPropertyName("gte")]
        public DateTime? Gte { get; set; }

        /// <summary>
        /// Filter for events created before the specified timestamp.
        /// </summary>
        [JsonProperty("lt")]
        [STJS.JsonPropertyName("lt")]
        public DateTime? Lt { get; set; }

        /// <summary>
        /// Filter for events created at or before the specified timestamp.
        /// </summary>
        [JsonProperty("lte")]
        [STJS.JsonPropertyName("lte")]
        public DateTime? Lte { get; set; }
    }
}
