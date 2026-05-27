// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class BalanceSettingsPaymentsSettlementTiming : StripeEntity<BalanceSettingsPaymentsSettlementTiming>
    {
        /// <summary>
        /// The number of days charge funds are held before becoming available.
        /// </summary>
        [JsonProperty("delay_days")]
        [STJS.JsonPropertyName("delay_days")]
        public long DelayDays { get; set; }

        /// <summary>
        /// The number of days charge funds are held before becoming available. If present,
        /// overrides the default, or minimum available, for the account.
        /// </summary>
        [JsonProperty("delay_days_override")]
        [STJS.JsonPropertyName("delay_days_override")]
        public long DelayDaysOverride { get; set; }

        /// <summary>
        /// Customized start of day configuration for automatic payouts to group and send payments
        /// in local timezones with a customized day starting time. For details, see our <a
        /// href="https://stripe.com/connect/customized-start-of-day">Customized start of day</a>
        /// documentation.
        /// </summary>
        [JsonProperty("start_of_day")]
        [STJS.JsonPropertyName("start_of_day")]
        public BalanceSettingsPaymentsSettlementTimingStartOfDay StartOfDay { get; set; }
    }
}
