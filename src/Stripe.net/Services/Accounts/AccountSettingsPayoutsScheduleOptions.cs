// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountSettingsPayoutsScheduleOptions : INestedOptions
    {
        /// <summary>
        /// The number of days charge funds are held before being paid out. May also be set to
        /// <c>minimum</c>, representing the lowest available value for the account country. Default
        /// is <c>minimum</c>. The <c>delay_days</c> parameter remains at the last configured value
        /// if <c>interval</c> is <c>manual</c>. <a
        /// href="https://stripe.com/connect/manage-payout-schedule">Learn more about controlling
        /// payout delay days</a>.
        /// </summary>
        [JsonProperty("delay_days")]
        [JsonConverter(typeof(AnyOfConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("delay_days")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
#endif
        public AnyOf<long?, AccountSettingsPayoutsScheduleDelayDays> DelayDays { get; set; }

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
        /// The day of the month when available funds are paid out, specified as a number between
        /// 1--31. Payouts nominally scheduled between the 29th and 31st of the month are instead
        /// sent on the last day of a shorter month. Required and applicable only if <c>interval</c>
        /// is <c>monthly</c>.
        /// </summary>
        [JsonProperty("monthly_anchor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("monthly_anchor")]
#endif
        public long? MonthlyAnchor { get; set; }

        /// <summary>
        /// The days of the month when available funds are paid out, specified as an array of
        /// numbers between 1--31. Payouts nominally scheduled between the 29th and 31st of the
        /// month are instead sent on the last day of a shorter month. Required and applicable only
        /// if <c>interval</c> is <c>monthly</c> and <c>monthly_anchor</c> is not set.
        /// </summary>
        [JsonProperty("monthly_payout_days")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("monthly_payout_days")]
#endif
        public List<long?> MonthlyPayoutDays { get; set; }

        /// <summary>
        /// The day of the week when available funds are paid out, specified as <c>monday</c>,
        /// <c>tuesday</c>, etc. Required and applicable only if <c>interval</c> is <c>weekly</c>.
        /// One of: <c>friday</c>, <c>monday</c>, <c>saturday</c>, <c>sunday</c>, <c>thursday</c>,
        /// <c>tuesday</c>, or <c>wednesday</c>.
        /// </summary>
        [JsonProperty("weekly_anchor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("weekly_anchor")]
#endif
        public string WeeklyAnchor { get; set; }

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
