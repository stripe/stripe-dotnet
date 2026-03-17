// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionTrialSettingsEndBehaviorOptions : INestedOptions
    {
        /// <summary>
        /// Indicates how the subscription's billing cycle anchor is reset when a trial ends.
        /// Defaults to <c>now</c>.
        /// One of: <c>now</c>, or <c>unchanged</c>.
        /// </summary>
        [JsonProperty("billing_cycle_anchor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_cycle_anchor")]
#endif
        public string BillingCycleAnchor { get; set; }

        /// <summary>
        /// Indicates how the subscription should change when the trial ends if the user did not
        /// provide a payment method.
        /// One of: <c>cancel</c>, <c>create_invoice</c>, or <c>pause</c>.
        /// </summary>
        [JsonProperty("missing_payment_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("missing_payment_method")]
#endif
        public string MissingPaymentMethod { get; set; }
    }
}
