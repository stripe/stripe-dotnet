using Newtonsoft.Json;

namespace Stripe
{
    public class StripeBalanceTransactionListOptions : StripeListOptions
    {
        [JsonProperty("available_on")]
        public StripeDateFilter AvailableOn { get; set; }

        [JsonProperty("created")]
        public StripeDateFilter Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("payout")]
        public string PayoutId { get; set; }

        [JsonProperty("source")]
        public string SourceId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
