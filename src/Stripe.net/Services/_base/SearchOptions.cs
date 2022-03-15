namespace Stripe
{
    using Newtonsoft.Json;

    public class SearchOptions : BaseOptions
    {
        /// <summary>
        /// A limit on the number of objects to be returned, between 1 and 100.
        /// </summary>
        [JsonProperty("limit")]
        public long? Limit { get; set; }

        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }
    }
}
