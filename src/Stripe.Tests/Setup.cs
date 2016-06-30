using Machine.Specifications;

namespace Stripe.Tests
{
    public class Setup : IAssemblyContext
    {
        void IAssemblyContext.OnAssemblyStart()
        {
            StripeConfiguration.SetApiKey("sk_test_zH6JDWg1Pk2jGnEJ5PfibhW3");
        }

        void IAssemblyContext.OnAssemblyComplete()
        {
            // great, we're done!
        }
    }
}