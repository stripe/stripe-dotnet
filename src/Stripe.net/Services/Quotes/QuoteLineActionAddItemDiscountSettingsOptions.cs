// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class QuoteLineActionAddItemDiscountSettingsOptions : INestedOptions
    {
        /// <summary>
        /// Configures service period cycle anchoring.
        /// </summary>
        [JsonProperty("service_period_anchor_config")]
        [STJS.JsonPropertyName("service_period_anchor_config")]
        public QuoteLineActionAddItemDiscountSettingsServicePeriodAnchorConfigOptions ServicePeriodAnchorConfig { get; set; }

        /// <summary>
        /// The start date of the discount's service period when applying a coupon or promotion code
        /// with a service period duration. Defaults to <c>line_start</c> if omitted.
        /// One of: <c>current_period_end</c>, <c>current_period_start</c>, or <c>line_start</c>.
        /// </summary>
        [JsonProperty("start_date")]
        [STJS.JsonPropertyName("start_date")]
        public string StartDate { get; set; }
    }
}
