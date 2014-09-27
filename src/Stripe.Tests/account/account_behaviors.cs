using Machine.Specifications;

namespace Stripe.Tests
{
    [Behaviors]
    public class account_behaviors
    {
        protected static StripeAccount StripeAccount;

        It should_have_an_id = () =>
            StripeAccount.Id.ShouldNotBeNull();
    }
}