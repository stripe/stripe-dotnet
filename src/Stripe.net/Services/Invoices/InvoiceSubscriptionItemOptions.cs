namespace Stripe
{
    using Stripe.Infrastructure;

    public class InvoiceSubscriptionItemOptions : BaseOptions
    {
        [FormProperty("id")]
        public string Id { get; set; }

        [FormProperty("deleted")]
        public bool? Deleted { get; set; }

        [FormProperty("plan")]
        public string PlanId { get; set; }

        [FormProperty("quantity")]
        public int? Quantity { get; set; }
    }
}
