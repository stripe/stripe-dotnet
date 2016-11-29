using Newtonsoft.Json;

namespace Stripe
{
    public class StripeFee : StripeEntity
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("application")]
        public string Application { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
