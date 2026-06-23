namespace Stripe
{
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    public class SearchOptions : BaseOptions
    {
        /// <summary>
        /// A limit on the number of objects to be returned, between 1 and 100.
        /// </summary>
        [JsonProperty("limit")]
        [STJS.JsonPropertyName("limit")]
        public long? Limit { get; set; }

        [JsonProperty("page")]
        [STJS.JsonPropertyName("page")]
        public string Page { get; set; }

        [JsonProperty("query")]
        [STJS.JsonPropertyName("query")]
        public string Query { get; set; }
    }
}
