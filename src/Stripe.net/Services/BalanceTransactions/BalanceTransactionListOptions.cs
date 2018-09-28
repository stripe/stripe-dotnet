namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    public class BalanceTransactionListOptions : ListOptionsWithCreated
    {
        [JsonProperty("available_on")]
        public DateTime? AvailableOn { get; set; }

        [JsonProperty("available_on")]
        public DateRangeOptions AvailableOnRange { get; set; }

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
