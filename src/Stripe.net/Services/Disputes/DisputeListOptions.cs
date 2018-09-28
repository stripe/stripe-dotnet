namespace Stripe
{
    using Stripe.Infrastructure;

    /// <summary>
    /// The optional arguments you can pass. <see href="https://stripe.com/docs/api#list_disputes">Stripe Documentation</see>
    /// </summary>
    public class DisputeListOptions : ListOptions
    {
        [FormProperty("created")]
        public DateFilter Created { get; set; }
    }
}
