namespace Stripe
{
    using Stripe.Infrastructure;

    public class EventListOptions : ListOptions
    {
        [FormProperty("type")]
        public string Type { get; set; }

        [FormProperty("created")]
        public DateFilter Created { get; set; }
    }
}
