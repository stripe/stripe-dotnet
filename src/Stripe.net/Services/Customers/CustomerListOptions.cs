namespace Stripe
{
    using Stripe.Infrastructure;

    public class CustomerListOptions : ListOptions
    {
        [FormProperty("created")]
        public DateFilter Created { get; set; }

        [FormProperty("email")]
        public string Email { get; set; }
    }
}
