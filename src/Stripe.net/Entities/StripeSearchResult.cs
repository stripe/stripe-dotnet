namespace Stripe
{
    using System.Collections;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [JsonObject]
    [STJS.JsonConverter(typeof(STJEnumerableObjectConverter))]
    public class StripeSearchResult<T> : StripeEntity<StripeSearchResult<T>>, IHasObject, IEnumerable<T>
    {
        /// <summary>
        /// A string describing the object type returned.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// A list containing the actual response elements, paginated by any request parameters.
        /// </summary>
        [JsonProperty("data", ItemConverterType = typeof(StripeObjectConverter))]
        [STJS.JsonPropertyName("data")] // STJ determines the conversion from annotations on the inner type
        public List<T> Data { get; set; }

        /// <summary>
        /// Whether or not there are more elements available after this set. If <c>false</c>,
        /// this set comprises the end of the list.
        /// </summary>
        [JsonProperty("has_more")]
        [STJS.JsonPropertyName("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// The URL for accessing this list.
        /// </summary>
        [JsonProperty("url")]
        [STJS.JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// The URL for accessing the next page in search results.
        /// </summary>
        [JsonProperty("next_page")]
        [STJS.JsonPropertyName("next_page")]
        public string NextPage { get; set; }

        /// <summary>
        /// The total count of entries in the search result, not just the current page.
        /// Only available when <see cref="BaseOptions.Expand"/> contains <c>"total_count"</c>.
        /// </summary>
        [JsonProperty("total_count")]
        [STJS.JsonPropertyName("total_count")]
        public long? TotalCount { get; set; }

        public IEnumerator<T> GetEnumerator()
        {
            return this.Data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.Data.GetEnumerator();
        }
    }
}
