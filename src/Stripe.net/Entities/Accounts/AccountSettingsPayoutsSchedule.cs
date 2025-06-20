// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountSettingsPayoutsSchedule : StripeEntity<AccountSettingsPayoutsSchedule>
    {
        /// <summary>
        /// The number of days charges for the account will be held before being paid out.
        /// </summary>
        [JsonProperty("delay_days")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("delay_days")]
#endif
        public long DelayDays { get; set; }

        /// <summary>
        /// How frequently funds will be paid out. One of <c>manual</c> (payouts only created via
        /// API call), <c>daily</c>, <c>weekly</c>, or <c>monthly</c>.
        /// </summary>
        [JsonProperty("interval")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("interval")]
#endif
        public string Interval { get; set; }

        /// <summary>
        /// The day of the month funds will be paid out. Only shown if <c>interval</c> is monthly.
        /// Payouts scheduled between the 29th and 31st of the month are sent on the last day of
        /// shorter months.
        /// </summary>
        [JsonProperty("monthly_anchor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("monthly_anchor")]
#endif
        public long MonthlyAnchor { get; set; }

        /// <summary>
        /// The days of the month funds will be paid out. Only shown if <c>interval</c> is monthly.
        /// Payouts scheduled between the 29th and 31st of the month are sent on the last day of
        /// shorter months.
        /// </summary>
        [JsonProperty("monthly_payout_days")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("monthly_payout_days")]
#endif
        public List<long> MonthlyPayoutDays { get; set; }

        /// <summary>
        /// The day of the week funds will be paid out, of the style 'monday', 'tuesday', etc. Only
        /// shown if <c>interval</c> is weekly.
        /// </summary>
        [JsonProperty("weekly_anchor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("weekly_anchor")]
#endif
        public string WeeklyAnchor { get; set; }

        /// <summary>
        /// The days of the week when available funds are paid out, specified as an array, for
        /// example, [<c>monday</c>, <c>tuesday</c>]. Only shown if <c>interval</c> is weekly.
        /// One of: <c>friday</c>, <c>monday</c>, <c>saturday</c>, <c>sunday</c>, <c>thursday</c>,
        /// <c>tuesday</c>, or <c>wednesday</c>.
        /// </summary>
        [JsonProperty("weekly_payout_days")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("weekly_payout_days")]
#endif
        public List<string> WeeklyPayoutDays { get; set; }
    }
}
