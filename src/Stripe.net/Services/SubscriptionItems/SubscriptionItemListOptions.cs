namespace Stripe
{
    using Stripe.Infrastructure;

    public class SubscriptionItemListOptions : ListOptions
    {
        /// <summary>
        /// REQUIRED: The ID of the subscription whose items will be retrieved.
        /// </summary>
        [FormProperty("subscription")]
        public string SubscriptionId { get; set; }
    }
}
