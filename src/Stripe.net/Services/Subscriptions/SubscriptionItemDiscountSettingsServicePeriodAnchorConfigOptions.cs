// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionItemDiscountSettingsServicePeriodAnchorConfigOptions : INestedOptions
    {
        /// <summary>
        /// Anchor the service period to a custom date. Type must be <c>custom</c> to specify.
        /// </summary>
        [JsonProperty("custom")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("custom")]
#endif
        public SubscriptionItemDiscountSettingsServicePeriodAnchorConfigCustomOptions Custom { get; set; }

        /// <summary>
        /// The type of service period anchor config. Defaults to
        /// <c>subscription_service_cycle_anchor</c> if omitted.
        /// One of: <c>custom</c>, or <c>subscription_service_cycle_anchor</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
