// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class QuoteLineActionAddItemDiscountSettingsServicePeriodAnchorConfigOptions : INestedOptions
    {
        /// <summary>
        /// Anchor the service period to a custom date. Type must be <c>custom</c> to specify.
        /// </summary>
        [JsonProperty("custom")]
        [STJS.JsonPropertyName("custom")]
        public QuoteLineActionAddItemDiscountSettingsServicePeriodAnchorConfigCustomOptions Custom { get; set; }

        /// <summary>
        /// The type of service period anchor config. Defaults to <c>inherit</c> if omitted.
        /// One of: <c>custom</c>, or <c>inherit</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
