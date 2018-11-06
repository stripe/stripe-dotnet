namespace Stripe
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    [JsonObject]
    public class StripeList<T> : StripeEntity, IHasObject, IEnumerable<T>
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("data", ItemConverterType = typeof(StripeListItemConverter))]
        public List<T> Data { get; set; }

        /// <summary>
        /// This field is only valid in the context of paging.
        /// </summary>
        [JsonProperty("has_more")]
        public bool HasMore { get; set; }

        [JsonProperty("total_count")]
        public long TotalCount { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

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
