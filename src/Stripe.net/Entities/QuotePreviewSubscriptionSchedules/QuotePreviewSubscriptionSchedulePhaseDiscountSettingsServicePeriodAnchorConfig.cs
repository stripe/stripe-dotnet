// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QuotePreviewSubscriptionSchedulePhaseDiscountSettingsServicePeriodAnchorConfig : StripeEntity<QuotePreviewSubscriptionSchedulePhaseDiscountSettingsServicePeriodAnchorConfig>
    {
        [JsonProperty("custom")]
        [STJS.JsonPropertyName("custom")]
        public QuotePreviewSubscriptionSchedulePhaseDiscountSettingsServicePeriodAnchorConfigCustom Custom { get; set; }

        /// <summary>
        /// The type of service period anchor config.
        /// One of: <c>custom</c>, or <c>inherit</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
