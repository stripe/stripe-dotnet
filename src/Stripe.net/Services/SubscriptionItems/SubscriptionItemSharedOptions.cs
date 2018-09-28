namespace Stripe
{
    using System;
    using Stripe.Infrastructure;

    public abstract class SubscriptionItemSharedOptions : BaseOptions
    {
        /// <summary>
        /// REQUIRED: The identifier of the plan to add to the subscription.
        /// </summary>
        [FormProperty("plan")]
        public string PlanId { get; set; }

        /// <summary>
        /// Flag indicating whether to prorate switching plans during a billing cycle.
        /// </summary>
        [FormProperty("prorate")]
        public bool? Prorate { get; set; }

        /// <summary>
        /// If set, the proration will be calculated as though the subscription was updated at the given time. This can be used to apply the same proration that was previewed with the upcoming invoice endpoint.
        /// </summary>
        [FormProperty("proration_date")]
        public DateTime? ProrationDate { get; set; }

        /// <summary>
        /// The quantity you’d like to apply to the subscription item you’re creating.
        /// </summary>
        [FormProperty("quantity")]
        public int? Quantity { get; set; }
    }
}
