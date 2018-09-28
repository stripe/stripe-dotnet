namespace Stripe
{
    using Stripe.Infrastructure;

    public class InvoiceItemListOptions : ListOptions
    {
        [FormProperty("customer")]
        public string CustomerId { get; set; }

        [FormProperty("created")]
        public DateFilter Created { get; set; }
    }
}
