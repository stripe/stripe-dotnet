// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QuoteLineTrialSettings : StripeEntity<QuoteLineTrialSettings>
    {
        /// <summary>
        /// Defines how the subscription should behave when a trial ends.
        /// </summary>
        [JsonProperty("end_behavior")]
        [STJS.JsonPropertyName("end_behavior")]
        public QuoteLineTrialSettingsEndBehavior EndBehavior { get; set; }
    }
}
