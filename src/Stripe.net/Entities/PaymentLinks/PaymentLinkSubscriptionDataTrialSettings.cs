// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentLinkSubscriptionDataTrialSettings : StripeEntity<PaymentLinkSubscriptionDataTrialSettings>
    {
        /// <summary>
        /// Defines how a subscription behaves when a free trial ends.
        /// </summary>
        [JsonProperty("end_behavior")]
        public PaymentLinkSubscriptionDataTrialSettingsEndBehavior EndBehavior { get; set; }
    }
}
