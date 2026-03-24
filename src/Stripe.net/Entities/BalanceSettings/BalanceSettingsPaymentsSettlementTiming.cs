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
    }
}
