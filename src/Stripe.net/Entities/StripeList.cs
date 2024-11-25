namespace Stripe
{
    using System.Collections;
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    using Stripe.Infrastructure;

    [JsonObject]
    [NoSystemTextJsonAttributesNeeded("JsonObject is implied by System.Text.Json")]
    public class StripeList<T> : StripeEntity<StripeList<T>>, IHasObject, IEnumerable<T>
    {
        /// <summary>
        /// A string describing the object type returned.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// A list containing the actual response elements, paginated by any request parameters.
        /// </summary>
        [JsonProperty("data", ItemConverterType = typeof(StripeObjectConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("data")] // ItemConverterType is not necessary; STJ determines the conversion from the underlying data type.
#endif
        public List<T> Data { get; set; }

        /// <summary>
        /// Whether or not there are more elements available after this set. If <c>false</c>,
        /// this set comprises the end of the list.
        /// </summary>
        [JsonProperty("has_more")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("has_more")]
#endif
        public bool HasMore { get; set; }

        /// <summary>
        /// The URL for accessing this list.
        /// </summary>
        [JsonProperty("url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("url")]
#endif
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
