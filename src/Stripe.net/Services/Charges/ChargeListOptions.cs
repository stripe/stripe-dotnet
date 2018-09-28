namespace Stripe
{
    using Stripe.Infrastructure;

    public class ChargeListOptions : ListOptions
    {
        [FormProperty("created")]
        public DateFilter Created { get; set; }

        [FormProperty("customer")]
        public string CustomerId { get; set; }
    }
}
