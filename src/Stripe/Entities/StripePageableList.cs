using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripePageableList<T>
    {
        [JsonProperty("object")]
        protected string Object { get; set; }

        [JsonProperty("has_more")]
        protected bool HasMore { get; set; }

        [JsonProperty("url")]
        protected string Url { get; set; }

        [JsonProperty("total_count")]
        protected int TotalCount { get; set; }

        [JsonProperty("data")]
        public List<T> Data { get; set; }
    }
}