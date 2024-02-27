namespace StripeTests.Infrastructure.TestData
{
    using System;
    using Stripe;

    public class TestService : Service<Charge>
    {
        public TestService()
            : base(null)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/charges";
    }
}
