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
        /// Change <c>delay_days</c> for this account, which determines the number of days charge
        /// funds are held before becoming available. The maximum value is 31. Passing an empty
        /// string to <c>delay_days_override</c> will return <c>delay_days</c> to the default, which
        /// is the lowest available value for the account. <a
        /// href="https://stripe.com/connect/manage-payout-schedule">Learn more about controlling
        /// delay days</a>.
        /// </summary>
        [JsonProperty("delay_days_override")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("delay_days_override")]
#endif
        public long? DelayDaysOverride { get; set; }
    }
}
