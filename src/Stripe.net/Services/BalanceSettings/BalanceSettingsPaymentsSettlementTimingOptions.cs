// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class BalanceSettingsPaymentsSettlementTimingOptions : INestedOptions
    {
        /// <summary>
        /// The number of days charge funds are held before becoming available. May also be set to
        /// <c>minimum</c>, representing the lowest available value for the account country. Default
        /// is <c>minimum</c>. The <c>delay_days</c> parameter remains at the last configured value
        /// if <c>payouts.schedule.interval</c> is <c>manual</c>. <a
        /// href="https://stripe.com/connect/manage-payout-schedule">Learn more about controlling
        /// payout delay days</a>.
        /// </summary>
        [JsonProperty("delay_days_override")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("delay_days_override")]
#endif
        public long? DelayDaysOverride { get; set; }
    }
}
