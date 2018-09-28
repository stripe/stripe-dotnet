namespace Stripe
{
    using Stripe.Infrastructure;

    public class FileListOptions : ListOptions
    {
        [FormProperty("created")]
        public DateFilter Created { get; set; }

        [FormProperty("purpose")]
        public string Purpose { get; set; }
    }
}
