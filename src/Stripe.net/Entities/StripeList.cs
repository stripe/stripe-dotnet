using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    [JsonObject]
    public class StripeList<T> : StripeEntity, IEnumerable<T>
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("data")]
        public List<T> Data { get; set; }

        /// <summary>
        /// This field is only valid in the context of paging.
        /// </summary>
        [JsonProperty("has_more")]
        public bool HasMore { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        public IEnumerator<T> GetEnumerator()
        {
            return Data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Data.GetEnumerator();
        }
    }
}