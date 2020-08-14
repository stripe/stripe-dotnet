namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSettingsPayoutsScheduleOptions : INestedOptions
    {
        /// <summary>
        /// temp.
        /// </summary>
        [JsonProperty("delay_days")]
        public string DelayDays { get; set; }

        /// <summary>
        /// How frequently available funds are paid out. One of: <c>daily</c>, <c>manual</c>,
        /// <c>weekly</c>, or <c>monthly</c>. Default is <c>daily</c>.
        /// One of: <c>daily</c>, <c>manual</c>, <c>monthly</c>, or <c>weekly</c>.
        /// </summary>
        [JsonProperty("interval")]
        public string Interval { get; set; }

        /// <summary>
        /// The day of the month when available funds are paid out, specified as a number between
        /// 1--31. Payouts nominally scheduled between the 29th and 31st of the month are instead
        /// sent on the last day of a shorter month. Required and applicable only if <c>interval</c>
        /// is <c>monthly</c>.
        /// </summary>
        [JsonProperty("monthly_anchor")]
        public string MonthlyAnchor { get; set; }

        /// <summary>
        /// The day of the week when available funds are paid out, specified as <c>monday</c>,
        /// <c>tuesday</c>, etc. (required and applicable only if <c>interval</c> is <c>weekly</c>.).
        /// One of: <c>friday</c>, <c>monday</c>, <c>saturday</c>, <c>sunday</c>, <c>thursday</c>,
        /// <c>tuesday</c>, or <c>wednesday</c>.
        /// </summary>
        [JsonProperty("weekly_anchor")]
        public string WeeklyAnchor { get; set; }
    }
}
