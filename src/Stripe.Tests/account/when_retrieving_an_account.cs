using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_retrieving_an_account
    {
        protected static StripeAccount StripeAccount;

        private static StripeAccountService _stripeAccountService;

        Establish context = () =>
        {
            _stripeAccountService = new StripeAccountService();
        };

        Because of = () =>
        {
            StripeAccount = _stripeAccountService.Get();
        };

        Behaves_like<account_behaviors> behaviors;
    }
}
