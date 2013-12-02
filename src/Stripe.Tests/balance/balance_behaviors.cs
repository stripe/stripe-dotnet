using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    [Behaviors]
    public class balance_behaviors
    {
        protected static StripeBalance StripeBalance;

        It should_have_pending_amounts = () =>
            StripeBalance.Pending.Length.ShouldBeGreaterThan(0);

        It should_have_available_amounts = () =>
            StripeBalance.Available.Length.ShouldBeGreaterThan(0);

        private It should_specify_currency_on_available_amount = () =>
            StripeBalance.Available.First().Currency.ShouldNotBeNull();
    }
}
