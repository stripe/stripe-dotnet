// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentLinkSubscriptionDataTrialSettings : StripeEntity<PaymentLinkSubscriptionDataTrialSettings>
    {
        /// <summary>
        /// Defines how a subscription behaves when a free trial ends.
        /// </summary>
        [JsonProperty("end_behavior")]
        [STJS.JsonPropertyName("end_behavior")]
        public PaymentLinkSubscriptionDataTrialSettingsEndBehavior EndBehavior { get; set; }
    }
}
