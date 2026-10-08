namespace Stripe.V2
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
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]
        public List<T> Data { get; set; }

        [JsonProperty("next_page_url")]
        [STJS.JsonPropertyName("next_page_url")]
        public string NextPageUrl { get; set; }

        [JsonProperty("previous_page_url")]
        [STJS.JsonPropertyName("previous_page_url")]
        public string PreviousPageUrl { get; set; }

        [JsonProperty("total_count")]
        [STJS.JsonPropertyName("total_count")]
        public long TotalCount { get; set; }

        public IEnumerator<T> GetEnumerator() => this.Data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
