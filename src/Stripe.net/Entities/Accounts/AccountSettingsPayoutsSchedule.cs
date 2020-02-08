namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AccountSettingsPayoutsSchedule : StripeEntity<AccountSettingsPayoutsSchedule>
    {
        [JsonProperty("delay_days")]
        public long DelayDays { get; set; }

        [JsonProperty("interval")]
        public string Interval { get; set; }

        [JsonProperty("monthly_anchor")]
        public long MonthlyAnchor { get; set; }

        [JsonProperty("weekly_anchor")]
        public string WeeklyAnchor { get; set; }
    }
}
