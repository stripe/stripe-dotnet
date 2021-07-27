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

        [JsonProperty("next_page")]
        public string NextPage { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }
    }
}
