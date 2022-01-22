// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentLinkSubscriptionData : StripeEntity<PaymentLinkSubscriptionData>
    {
        /// <summary>
        /// When creating a subscription, the specified configuration data will be used. There must
        /// be at least one line item with a recurring price to use <c>subscription_data</c>.
        /// </summary>
        [JsonProperty("trial_period_days")]
        public long? TrialPeriodDays { get; set; }
    }
}
