namespace Stripe.V2
{
    using System.Collections;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [JsonObject]
    [STJS.JsonConverter(typeof(STJEnumerableObjectConverter))]
    public class StripeList<T> : StripeEntity<StripeList<T>>, IEnumerable<T>
    {
        /// <summary>
        /// A list containing the actual response elements, paginated by any request parameters.
        /// TODO(jar) does this need an ItemConverterType (like in Stripe.StripeList).
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]
        public List<T> Data { get; set; }

        /// <summary>
        /// The URL for accessing this list.
        /// </summary>
        [JsonProperty("next_page_url")]
        [STJS.JsonPropertyName("next_page_url")]
        public string NextPageUrl { get; set; }

        /// <summary>
        /// The URL for accessing this list.
        /// </summary>
        [JsonProperty("previous_page_url")]
        [STJS.JsonPropertyName("previous_page_url")]
        public string PreviousPageUrl { get; set; }

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
