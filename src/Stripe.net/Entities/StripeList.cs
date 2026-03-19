namespace Stripe
{
    using System.Collections;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [JsonObject]
    [STJS.JsonConverter(typeof(STJEnumerableObjectConverter))]
    public class StripeList<T> : StripeEntity<StripeList<T>>, IHasObject, IEnumerable<T>
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

        public IEnumerator<T> GetEnumerator()
        {
            return this.Data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.Data.GetEnumerator();
        }

        /// <summary>
        /// Reverse the order of the items in Data to support backward iteration
        /// in autopagination with EndingBefore.
        /// </summary>
        public void Reverse()
        {
            this.Data.Reverse();
        }
    }
}
