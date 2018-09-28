namespace Stripe
{
    using Stripe.Infrastructure;

    public class SourceCardUpdateOptions : INestedOptions
    {
        [FormProperty("exp_month")]
        public int? ExpirationMonth { get; set; }

        [FormProperty("exp_year")]
        public int? ExpirationYear { get; set; }
    }
}
