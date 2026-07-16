// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SubscriptionSchedulePauseScheduleResumeSettingsOptions : INestedOptions
    {
        /// <summary>
        /// Controls the billing cycle anchor when the subscription resumes.
        /// One of: <c>resume_at</c>, or <c>unchanged</c>.
        /// </summary>
        [JsonProperty("billing_cycle_anchor")]
        [STJS.JsonPropertyName("billing_cycle_anchor")]
        public string BillingCycleAnchor { get; set; }

        /// <summary>
        /// Controls whether Stripe attempts payment on the resumption invoice and how payment
        /// affects the subscription's status. The default is <c>resume_on_payment_attempt</c>.
        /// One of: <c>resume_on_payment_attempt</c>, or <c>resume_on_payment_success</c>.
        /// </summary>
        [JsonProperty("payment_behavior")]
        [STJS.JsonPropertyName("payment_behavior")]
        public string PaymentBehavior { get; set; }

        /// <summary>
        /// Determines how to handle prorations when the subscription resumes. The default is
        /// <c>create_prorations</c>.
        /// One of: <c>always_invoice</c>, <c>create_prorations</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
        [STJS.JsonPropertyName("proration_behavior")]
        public string ProrationBehavior { get; set; }
    }
}
