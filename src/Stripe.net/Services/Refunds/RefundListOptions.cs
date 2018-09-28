namespace Stripe
{
    using Stripe.Infrastructure;

    public class RefundListOptions : ListOptions
    {
        [FormProperty("charge")]
        public string ChargeId { get; set; }
    }
}
