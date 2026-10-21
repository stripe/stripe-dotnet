// File generated from our OpenAPI spec
namespace Stripe.V2.Data
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A ranked set of public analytical resources matching a natural-language query.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SearchResultList : StripeEntity<SearchResultList>, IHasObject
    {
        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Domain-level intelligence. Present when a known domain matches; omitted when the system
        /// falls back to direct semantic search.
        /// </summary>
        [JsonProperty("context")]
        [STJS.JsonPropertyName("context")]
        public SearchResultListContext Context { get; set; }

        /// <summary>
        /// Ranked public resources. Always present, including when empty.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]
        public List<SearchResultListData> Data { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Token for the next page.
        /// </summary>
        [JsonProperty("next_page_url")]
        [STJS.JsonPropertyName("next_page_url")]
        public string NextPageUrl { get; set; }

        /// <summary>
        /// Token for the previous page.
        /// </summary>
        [JsonProperty("previous_page_url")]
        [STJS.JsonPropertyName("previous_page_url")]
        public string PreviousPageUrl { get; set; }
    }
}
