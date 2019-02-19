namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSettingsPayoutsScheduleOptions : INestedOptions
    {
        [JsonProperty("delay_days")]
        public string DelayDays { get; set; }

        [JsonProperty("interval")]
        public string Interval { get; set; }

        [JsonProperty("monthly_anchor")]
        public string MonthlyAnchor { get; set; }

        [JsonProperty("weekly_anchor")]
        public string WeeklyAnchor { get; set; }
    }
}
