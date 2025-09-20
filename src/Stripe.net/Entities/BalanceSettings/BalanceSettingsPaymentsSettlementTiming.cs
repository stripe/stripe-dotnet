// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class BalanceSettingsPaymentsSettlementTiming : StripeEntity<BalanceSettingsPaymentsSettlementTiming>
    {
        /// <summary>
        /// The number of days charge funds are held before becoming available.
        /// </summary>
        [JsonProperty("delay_days")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("delay_days")]
#endif
        public long DelayDays { get; set; }

        /// <summary>
        /// The number of days charge funds are held before becoming available. If present,
        /// overrides the default, or minimum available, for the account.
        /// </summary>
        [JsonProperty("delay_days_override")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("delay_days_override")]
#endif
        public long DelayDaysOverride { get; set; }
    }
}
