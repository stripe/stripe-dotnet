namespace StripeTests.Infrastructure.TestData
{
    using Stripe;

    public class TestService : Service<Charge>
    {
        public TestService()
            : base(null)
        {
        }

        public bool ExpandSimple { get; set; }

        public bool ExpandMultiWordProperty { get; set; }
    }
}
