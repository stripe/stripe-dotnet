// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoiceScheduleDetailsAmendmentDiscountActionAddSettingsOptions : INestedOptions
    {
        /// <summary>
        /// Configures service period cycle anchoring.
        /// </summary>
        [JsonProperty("service_period_anchor_config")]
        [STJS.JsonPropertyName("service_period_anchor_config")]
        public InvoiceScheduleDetailsAmendmentDiscountActionAddSettingsServicePeriodAnchorConfigOptions ServicePeriodAnchorConfig { get; set; }

        /// <summary>
        /// The start date of the discount's service period when applying a coupon or promotion code
        /// with a service period duration. Defaults to <c>amendment_start</c> if omitted.
        /// One of: <c>amendment_start</c>, <c>current_period_end</c>, or
        /// <c>current_period_start</c>.
        /// </summary>
        [JsonProperty("start_date")]
        [STJS.JsonPropertyName("start_date")]
        public string StartDate { get; set; }
    }
}
