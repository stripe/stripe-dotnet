namespace Stripe
{
    using Stripe.Infrastructure;

    public class TopupListOptions : ListOptions
    {
        [FormProperty("created")]
        public DateFilter Created { get; set; }
    }
}
