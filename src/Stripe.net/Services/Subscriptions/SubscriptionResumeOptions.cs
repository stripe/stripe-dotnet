// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionResumeOptions : BaseOptions
    {
        /// <summary>
        /// The billing cycle anchor that applies when the subscription is resumed. Either
        /// <c>now</c> or <c>unchanged</c>. The default is <c>now</c>. For more information, see the
        /// billing cycle <a
        /// href="https://docs.stripe.com/billing/subscriptions/billing-cycle">documentation</a>.
        /// One of: <c>now</c>, or <c>unchanged</c>.
        /// </summary>
        [JsonProperty("billing_cycle_anchor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_cycle_anchor")]
#endif
        public SubscriptionBillingCycleAnchor BillingCycleAnchor { get; set; }

        /// <summary>
        /// Controls when the subscription transitions from <c>paused</c> to <c>active</c>.
        /// Determines how payment on the invoice affects the resumption process.The default is
        /// <c>pending_if_incomplete</c>.
        /// One of: <c>allow_incomplete</c>, or <c>pending_if_incomplete</c>.
        /// </summary>
        [JsonProperty("payment_behavior")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_behavior")]
#endif
        public string PaymentBehavior { get; set; }

        /// <summary>
        /// Determines how to handle <a
        /// href="https://docs.stripe.com/billing/subscriptions/prorations">prorations</a> resulting
        /// from the <c>billing_cycle_anchor</c> being <c>unchanged</c>. When the
        /// <c>billing_cycle_anchor</c> is set to <c>now</c> (default value), no prorations are
        /// generated. If no value is passed, the default is <c>create_prorations</c>.
        /// One of: <c>always_invoice</c>, <c>create_prorations</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("proration_behavior")]
#endif
        public string ProrationBehavior { get; set; }

        /// <summary>
        /// If set, prorations will be calculated as though the subscription was resumed at the
        /// given time. This can be used to apply exactly the same prorations that were previewed
        /// with the <a href="https://stripe.com/docs/api/invoices/create_preview">create
        /// preview</a> endpoint.
        /// </summary>
        [JsonProperty("proration_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("proration_date")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? ProrationDate { get; set; }
    }
}
