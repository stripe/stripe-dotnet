using Newtonsoft.Json;

namespace Stripe
{
    public class StripePlanTier
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("up_to")]
        public int? UpTo { get; set; }
    }
}