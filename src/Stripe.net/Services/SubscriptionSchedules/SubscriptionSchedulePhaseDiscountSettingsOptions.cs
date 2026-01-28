// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionSchedulePhaseDiscountSettingsOptions : INestedOptions
    {
        /// <summary>
        /// Configures service period cycle anchoring.
        /// </summary>
        [JsonProperty("service_period_anchor_config")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("service_period_anchor_config")]
#endif
        public SubscriptionSchedulePhaseDiscountSettingsServicePeriodAnchorConfigOptions ServicePeriodAnchorConfig { get; set; }

        /// <summary>
        /// The start date of the discount's service period when applying a coupon or promotion code
        /// with a service period duration. Defaults to <c>phase_start</c> if omitted.
        /// One of: <c>current_period_end</c>, <c>current_period_start</c>, or <c>phase_start</c>.
        /// </summary>
        [JsonProperty("start_date")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("start_date")]
#endif
        public string StartDate { get; set; }
    }
}
