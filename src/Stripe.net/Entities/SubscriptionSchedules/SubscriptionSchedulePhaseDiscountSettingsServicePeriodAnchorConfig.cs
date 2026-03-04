// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionSchedulePhaseDiscountSettingsServicePeriodAnchorConfig : StripeEntity<SubscriptionSchedulePhaseDiscountSettingsServicePeriodAnchorConfig>
    {
        [JsonProperty("custom")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("custom")]
#endif
        public SubscriptionSchedulePhaseDiscountSettingsServicePeriodAnchorConfigCustom Custom { get; set; }

        /// <summary>
        /// The type of service period anchor config.
        /// One of: <c>custom</c>, or <c>inherit</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
