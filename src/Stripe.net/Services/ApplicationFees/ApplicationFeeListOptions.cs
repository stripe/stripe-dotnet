namespace Stripe
{
    using Stripe.Infrastructure;

    public class ApplicationFeeListOptions : ListOptions
    {
        [FormProperty("charge")]
        public string ChargeId { get; set; }

        [FormProperty("created")]
        public DateFilter Created { get; set; }
    }
}
