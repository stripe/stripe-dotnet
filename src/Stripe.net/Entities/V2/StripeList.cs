namespace Stripe.V2
{
    using System.Collections;
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    [JsonObject]
    [NoSystemTextJsonAttributesNeeded("JsonObject is implied by System.Text.Json")]
    public class StripeList<T> : StripeEntity<StripeList<T>>, IEnumerable<T>
    {
        /// <summary>
        /// A list containing the actual response elements, paginated by any request parameters.
        /// </summary>
        [JsonProperty("data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("data")]
#endif
        public List<T> Data { get; set; }

        /// <summary>
        /// The URL for accessing this list.
        /// </summary>
        [JsonProperty("next_page_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("next_page_url")]
#endif
        public string NextPageUrl { get; set; }

        /// <summary>
        /// The URL for accessing this list.
        /// </summary>
        [JsonProperty("previous_page_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("previous_page_url")]
#endif
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
