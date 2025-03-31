namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SearchOptions : BaseOptions
    {
        /// <summary>
        /// A limit on the number of objects to be returned, between 1 and 100.
        /// </summary>
        [JsonProperty("limit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("limit")]
#endif
        public long? Limit { get; set; }

        [JsonProperty("page")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("page")]
#endif
        public string Page { get; set; }

        [JsonProperty("query")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("query")]
#endif
        public string Query { get; set; }
    }
}
