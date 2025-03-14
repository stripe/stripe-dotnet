// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class QuoteLineSetPauseCollectionOptions : INestedOptions
    {
        /// <summary>
        /// Details of the pause_collection behavior to apply to the amendment.
        /// </summary>
        [JsonProperty("set")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("set")]
#endif
        public QuoteLineSetPauseCollectionSetOptions Set { get; set; }

        /// <summary>
        /// Determines the type of the pause_collection amendment.
        /// One of: <c>remove</c>, or <c>set</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
