namespace Stripe
{
    using Stripe.Infrastructure;

    public class TransferListOptions : ListOptions
    {
        [FormProperty("created")]
        public DateFilter Created { get; set; }

        [FormProperty("destination")]
        public string Destination { get; set; }

        [FormProperty("transfer_group")]
        public string TransferGroup { get; set; }
    }
}
