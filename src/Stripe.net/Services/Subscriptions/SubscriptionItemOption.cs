namespace Stripe
{
    using Stripe.Infrastructure;

    public class SubscriptionItemOption : INestedOptions
    {
        /// <summary>
        /// Plan ID for this item.
        /// </summary>
        [FormProperty("plan")]
        public string PlanId { get; set; }

        /// <summary>
        /// Quantity for this item.
        /// </summary>
        [FormProperty("quantity")]
        public int? Quantity { get; set; }
    }
}
