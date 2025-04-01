// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class BalanceSettingsPayoutsScheduleOptions : INestedOptions
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
        /// The day of the week when available funds are paid out (required and applicable only if
        /// <c>interval</c> is <c>weekly</c>.).
        /// One of: <c>friday</c>, <c>monday</c>, <c>thursday</c>, <c>tuesday</c>, or
        /// <c>wednesday</c>.
        /// </summary>
        [JsonProperty("weekly_anchor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("weekly_anchor")]
#endif
        public string WeeklyAnchor { get; set; }
    }
}
