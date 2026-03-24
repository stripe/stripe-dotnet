// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoiceSubscriptionDetailsItemDiscountSettingsServicePeriodAnchorConfigOptions : INestedOptions
    {
        /// <summary>
        /// Anchor the service period to a custom date. Type must be <c>custom</c> to specify.
        /// </summary>
        [JsonProperty("custom")]
        [STJS.JsonPropertyName("custom")]
        public InvoiceSubscriptionDetailsItemDiscountSettingsServicePeriodAnchorConfigCustomOptions Custom { get; set; }

        /// <summary>
        /// The type of service period anchor config. Defaults to
        /// <c>subscription_service_cycle_anchor</c> if omitted.
        /// One of: <c>custom</c>, or <c>subscription_service_cycle_anchor</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
