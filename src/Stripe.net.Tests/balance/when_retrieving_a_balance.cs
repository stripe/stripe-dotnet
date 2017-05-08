using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_retrieving_a_balance
    {
        protected static StripeBalance StripeBalance;

        private static StripeBalanceService _stripeBalanceService;

        Establish context = () =>
        {
            _stripeBalanceService = new StripeBalanceService();
        };

        Because of = () =>
        {
            StripeBalance = _stripeBalanceService.Get();
        };

#pragma warning disable 169, 414
        Behaves_like<balance_behaviors> behaviors;
#pragma warning restore 169, 414

    }
}
