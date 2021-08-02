// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class CustomerSearchOptions : BaseOptions
    {
        [JsonProperty("include_count")]
        public bool? IncludeCount { get; set; }

        [JsonProperty("next_page")]
        public string NextPage { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("search_window")]
        public string SearchWindow { get; set; }

        [JsonProperty("sort_order")]
        public string SortOrder { get; set; }
    }
}
