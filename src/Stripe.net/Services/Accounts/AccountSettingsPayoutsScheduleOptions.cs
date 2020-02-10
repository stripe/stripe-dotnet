namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

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
