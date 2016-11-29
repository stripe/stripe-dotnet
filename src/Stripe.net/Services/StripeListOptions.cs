using Newtonsoft.Json;

namespace Stripe
{
    public class StripeListOptions
    {
        [JsonProperty("limit")]
        public int? Limit { get; set; }

        [JsonProperty("starting_after")]
        public string StartingAfter { get; set; }

        [JsonProperty("ending_before")]
        public string EndingBefore { get; set; }
    }
}