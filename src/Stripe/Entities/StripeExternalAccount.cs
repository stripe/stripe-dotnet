using Newtonsoft.Json;

namespace Stripe
{
    public class StripeExternalAccount : StripeObject
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        //todo: confirm array of external accounts (bank accounts or cards)
        [JsonProperty("data")]
        public string[] data { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
                
    }
}