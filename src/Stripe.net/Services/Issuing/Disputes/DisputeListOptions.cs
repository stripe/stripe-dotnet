namespace Stripe.Issuing
{
    using Stripe.Infrastructure;

    public class DisputeListOptions : ListOptions
    {
        [FormProperty("created")]
        public DateFilter Created { get; set; }

        [FormProperty("transaction")]
        public string TransactionId { get; set; }
    }
}
