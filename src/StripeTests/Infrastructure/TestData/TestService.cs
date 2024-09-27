namespace StripeTests.Infrastructure.TestData
{
    using System;
    using Stripe;

    public class TestService : Service<Charge>
    {
        public TestService()
            : base()
        {
        }
    }
}
