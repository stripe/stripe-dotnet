// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SubscriptionTrialSettingsEndBehaviorOptions : INestedOptions
    {
        /// <summary>
        /// Indicates how the subscription's billing cycle anchor is reset when a trial ends.
        /// Defaults to <c>now</c>.
        /// One of: <c>now</c>, or <c>unchanged</c>.
        /// </summary>
        [JsonProperty("billing_cycle_anchor")]
        [STJS.JsonPropertyName("billing_cycle_anchor")]
        public string BillingCycleAnchor { get; set; }

        /// <summary>
        /// Indicates how the subscription should change when the trial ends if the user did not
        /// provide a payment method.
        /// One of: <c>cancel</c>, <c>create_invoice</c>, or <c>pause</c>.
        /// </summary>
        [JsonProperty("missing_payment_method")]
        [STJS.JsonPropertyName("missing_payment_method")]
        public string MissingPaymentMethod { get; set; }
    }
}
