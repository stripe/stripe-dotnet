namespace Stripe.Reporting
{
    using Stripe.Infrastructure;

    public class ReportRunListOptions : ListOptions
    {
        [FormProperty("created")]
        public DateFilter Created { get; set; }
    }
}
