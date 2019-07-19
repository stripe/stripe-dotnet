namespace StripeTests.Infrastructure.TestData
{
    using Stripe;

    public class TestService : Service<Charge>
    {
        public TestService()
            : base(null)
        {
        }

        public override string BasePath => "/charges";
    }
}
