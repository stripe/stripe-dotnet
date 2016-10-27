using Newtonsoft.Json;

namespace Stripe
{
    public class StripeTransferSchedule : StripeEntity
    {
        [JsonProperty("delay_days")]
        public int DelayDays { get; set; }

        [JsonProperty("interval")]
        public string Interval { get; set; }

        [JsonProperty("monthly_anchor")]
        public int MonthlyAnchor { get; set; }

        [JsonProperty("weekly_anchor")]
        public string WeeklyAnchor { get; set; }
    }
}
