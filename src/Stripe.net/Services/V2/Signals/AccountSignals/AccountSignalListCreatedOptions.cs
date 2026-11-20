// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountSignalListCreatedOptions : INestedOptions
    {
        /// <summary>
        /// Only return signals created after this RFC 3339 timestamp.
        /// </summary>
        [JsonProperty("gt")]
        [STJS.JsonPropertyName("gt")]
        public DateTime? Gt { get; set; }

        /// <summary>
        /// Only return signals created at or after this RFC 3339 timestamp.
        /// </summary>
        [JsonProperty("gte")]
        [STJS.JsonPropertyName("gte")]
        public DateTime? Gte { get; set; }

        /// <summary>
        /// Only return signals created before this RFC 3339 timestamp.
        /// </summary>
        [JsonProperty("lt")]
        [STJS.JsonPropertyName("lt")]
        public DateTime? Lt { get; set; }

        /// <summary>
        /// Only return signals created at or before this RFC 3339 timestamp.
        /// </summary>
        [JsonProperty("lte")]
        [STJS.JsonPropertyName("lte")]
        public DateTime? Lte { get; set; }
    }
}
