using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeDataList<T>
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("total_count")]
        public int? TotalCount { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }

        [JsonProperty("data")]
        public List<T> Data { get; set; } 
    }
}