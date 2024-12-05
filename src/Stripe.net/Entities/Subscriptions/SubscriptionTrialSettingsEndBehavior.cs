// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionTrialSettingsEndBehavior : StripeEntity<SubscriptionTrialSettingsEndBehavior>
    {
        /// <summary>
        /// Indicates how the subscription should change when the trial ends if the user did not
        /// provide a payment method.
        /// One of: <c>cancel</c>, <c>create_invoice</c>, or <c>pause</c>.
        /// </summary>
        [JsonProperty("missing_payment_method")]
        public string MissingPaymentMethod { get; set; }
    }
}
