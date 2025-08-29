// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class BalanceSettingsPaymentsPayoutsScheduleOptions : INestedOptions
    {
        /// <summary>
        /// How frequently available funds are paid out. One of: <c>daily</c>, <c>manual</c>,
        /// <c>weekly</c>, or <c>monthly</c>. Default is <c>daily</c>.
        /// One of: <c>daily</c>, <c>manual</c>, <c>monthly</c>, or <c>weekly</c>.
        /// </summary>
        [JsonProperty("interval")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("interval")]
#endif
        public string Interval { get; set; }

        /// <summary>
        /// The days of the month when available funds are paid out, specified as an array of
        /// numbers between 1--31. Payouts nominally scheduled between the 29th and 31st of the
        /// month are instead sent on the last day of a shorter month. Required and applicable only
        /// if <c>interval</c> is <c>monthly</c>.
        /// </summary>
        [JsonProperty("monthly_payout_days")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("monthly_payout_days")]
#endif
        public List<long?> MonthlyPayoutDays { get; set; }

        /// <summary>
        /// The days of the week when available funds are paid out, specified as an array, e.g.,
        /// [<c>monday</c>, <c>tuesday</c>]. Required and applicable only if <c>interval</c> is
        /// <c>weekly</c>.
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
