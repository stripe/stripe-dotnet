namespace Stripe
{
    using Stripe.Infrastructure;

    public class PlanListOptions : ListOptions
    {
        [FormProperty("active")]
        public bool? Active { get; set; }

        [FormProperty("created")]
        public DateFilter Created { get; set; }

        /// <summary>
        /// Only return plans for the given product.
        /// </summary>
        [FormProperty("product")]
        public string ProductId { get; set; }
    }
}
