namespace Stripe.Issuing
{
    using Stripe.Infrastructure;

    public class TransactionListOptions : ListOptions
    {
        [FormProperty("cardholder")]
        public string CardholderId { get; set; }

        [FormProperty("card")]
        public string CardId { get; set; }

        [FormProperty("created")]
        public DateFilter Created { get; set; }
    }
}
