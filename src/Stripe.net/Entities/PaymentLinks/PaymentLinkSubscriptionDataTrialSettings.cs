// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentLinkSubscriptionDataTrialSettings : StripeEntity<PaymentLinkSubscriptionDataTrialSettings>
    {
        /// <summary>
        /// Defines how a subscription behaves when a free trial ends.
        /// </summary>
        [JsonProperty("end_behavior")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("end_behavior")]
#endif

        public PaymentLinkSubscriptionDataTrialSettingsEndBehavior EndBehavior { get; set; }
    }
}
