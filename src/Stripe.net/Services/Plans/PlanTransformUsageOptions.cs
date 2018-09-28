namespace Stripe
{
    using Stripe.Infrastructure;

    public class PlanTransformUsageOptions : INestedOptions
    {
        [FormProperty("divide_by")]
        public int? DivideBy { get; set; }

        [FormProperty("round")]
        public string Round { get; set; }
    }
}
