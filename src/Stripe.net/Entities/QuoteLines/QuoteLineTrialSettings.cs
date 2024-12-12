// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class QuoteLineTrialSettings : StripeEntity<QuoteLineTrialSettings>
    {
        /// <summary>
        /// Defines how the subscription should behave when a trial ends.
        /// </summary>
        [JsonProperty("end_behavior")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("end_behavior")]
#endif
        public QuoteLineTrialSettingsEndBehavior EndBehavior { get; set; }
    }
}
